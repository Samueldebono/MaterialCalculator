using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Material.Calculator.Models;
using Material.Calculator.Utility;


namespace Material.Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public async Task<ActionResult> Calculator()
        {

            ViewBag.ProductTypesList = await 
                BusinessClients.GlobalsBusiness.GetProductypes();
            ViewBag.AreaTypesList = await 
                BusinessClients.GlobalsBusiness.GetAreaTypes();
            ViewBag.MeasurementTypes = await 
                BusinessClients.GlobalsBusiness.GetMeasurementTypes();

            CalculatorModel model = new CalculatorModel();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Calculator(CalculatorModel model)
        {
            ViewBag.ProductTypesList = await
                BusinessClients.GlobalsBusiness.GetProductypes();
            ViewBag.AreaTypesList = await
                BusinessClients.GlobalsBusiness.GetAreaTypes();
            ViewBag.MeasurementTypes = await
                BusinessClients.GlobalsBusiness.GetMeasurementTypes();


            return View(Calculate(model));
        }

        private CalculatorModel Calculate(CalculatorModel model)
        {
            var depth = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.DepthMeasurementTypes, model.Depth);
            switch (model.AreaType)
            {
                case CalculatorModel.AreaTypes.Circle:
                    if (model.Circle.Diameter.HasValue)
                    {
                        var radis = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Circle.MeasurementTypes, model.Circle.Diameter.Value) / 2;
                        model.ResultsCubes = ((radis * radis) * Math.PI) * depth;
                    }

                    break;
                case CalculatorModel.AreaTypes.Triangle:
                    if (model.Triangle.Edge1.HasValue && model.Triangle.Edge2.HasValue && model.Triangle.Edge3.HasValue)
                    {
                        var edge1 = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Triangle.MeasurementTypeEdge1,model.Triangle.Edge1.Value);
                        var edge2 = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Triangle.MeasurementTypeEdge2,model.Triangle.Edge2.Value);
                        var edge3 = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Triangle.MeasurementTypeEdge3,model.Triangle.Edge3.Value);

                        var p = (edge1 + edge2 + edge3) / 2;
                        var area = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
                        model.ResultsCubes = area * depth;
                    }

                    break;
                case CalculatorModel.AreaTypes.Square:
                    if (model.Square.Length.HasValue && model.Square.Width.HasValue)
                        model.ResultsCubes = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Square.MeasurementTypesLength, model.Square.Length.Value)
                                             * BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Square.MeasurementTypesWidth, model.Square.Width.Value)
                                             * depth;
                    break;
            }

            //if (model.Square.Length.HasValue && model.Square.Width.HasValue)
            //    model.ResultsCubes = BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Square.MeasurementTypesLength,model.Square.Length.Value) 
            //                         * BusinessClients.GlobalsBusiness.ConvertToMillimetres(model.Square.MeasurementTypesWidth, model.Square.Width.Value)
            //                         * depth;

            model.ResultsTonnes = BusinessClients.GlobalsBusiness.GetConversationRate(model.ProductType, model.ResultsCubes);


            return model;
        }


    }
}