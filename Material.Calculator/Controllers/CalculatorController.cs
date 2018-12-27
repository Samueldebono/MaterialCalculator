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

           

            return View(Calculate(model));
        }

        private CalculatorModel Calculate(CalculatorModel model)
        {
            switch (model.AreaType)
            {
                case CalculatorModel.AreaTypes.Circle:
                    if (model.Diameter.HasValue)
                    {
                        var radis = model.Diameter.Value / 2;
                        model.ResultsCubes = ((radis * radis) * Math.PI) * (model.Depth / 10);
                    }

                    break;
                case CalculatorModel.AreaTypes.Triangle:
                    if (model.Edge1.HasValue && model.Edge2.HasValue && model.Edge3.HasValue)
                    {
                        var p = (model.Edge1.Value + model.Edge2.Value + model.Edge3.Value) / 2;
                        var area = Math.Sqrt(p * (p - model.Edge1.Value) * (p - model.Edge1.Value) *
                                             (p - model.Edge3.Value));
                        model.ResultsCubes = area * (model.Depth / 10);
                    }

                    break;
                case CalculatorModel.AreaTypes.Square:
                    if (model.Length.HasValue && model.Width.HasValue)
                        model.ResultsCubes = model.Length.Value * model.Width.Value * (model.Depth / 10);
                    break;
            }
            if (model.Length.HasValue && model.Width.HasValue)
                model.ResultsCubes = model.Length.Value * model.Width.Value * (model.Depth / 10);

            model.ResultsTonnes = BusinessClients.GlobalsBusiness.GetConversationRate(model.ProductType, model.ResultsCubes);


            return model;
        }


    }
}