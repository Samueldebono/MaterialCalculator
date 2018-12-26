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

            CalculatorModel model = new CalculatorModel();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Calculator(CalculatorModel model)
        {
            ViewBag.ProductTypesList = await
                BusinessClients.GlobalsBusiness.GetProductypes();
            model.ResultsCubes = model.Length * model.Depth * (model.Width/10);
            model.ResultsTonnes = BusinessClients.GlobalsBusiness.GetConversationRate(model.ProductType, model.ResultsCubes);



            return View(model);
        }


    }
}