using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Material.Calculator.Models;

namespace Material.Calculator.Utility
{
    public class Globals
    {
        public async Task<List<SelectListItem>> GetProductypes()
        {
            var list = (ProductsModel.ProductTypes[])(Enum.GetValues(typeof(ProductsModel.ProductTypes)).Cast<ProductsModel.ProductTypes>());

            return list.Select(r => new SelectListItem
                {
                    Text = GetStringProduct(r),
                    Value = Convert.ToInt32(r).ToString()
                }).OrderByDescending(r => r.Value)
                .ToList();
            
        }
        public double GetConversationRate(ProductsModel.ProductTypes type, double cubes)
        {
            if (cubes <= 0)
            {
                return 0;
            }
            
            switch (type)
            {
                case ProductsModel.ProductTypes.Soil:
                    return cubes * GlobalConversions.SoilRate;
                case ProductsModel.ProductTypes.TurfUnderlaySoil:
                    return cubes * GlobalConversions.TurfUnderlaySoil;
                case ProductsModel.ProductTypes.GardenMix:
                    return cubes * GlobalConversions.GardenMix;
                case ProductsModel.ProductTypes.TopSoil:
                    return cubes * GlobalConversions.SoilRate;
                case ProductsModel.ProductTypes.Sand:
                    return cubes * GlobalConversions.SandRate;
                case ProductsModel.ProductTypes.Bark:
                    return cubes * GlobalConversions.BarkRate;
                case ProductsModel.ProductTypes.Pebbles:
                    return cubes * GlobalConversions.PebbleRate;
                default:
                    return cubes; 
                    
            }
        }

        public string GetStringProduct(ProductsModel.ProductTypes type)
        {
            switch (type)
            {
                case ProductsModel.ProductTypes.Sand:
                    return "Sand";
                case ProductsModel.ProductTypes.TurfUnderlaySoil:
                    return "Turf Underlay";
                case ProductsModel.ProductTypes.GardenMix:
                    return "Garden Mix";
                case ProductsModel.ProductTypes.Soil:
                    return "Sand";
                case ProductsModel.ProductTypes.TopSoil:
                    return "Top Soil";
                case ProductsModel.ProductTypes.Pebbles:
                    return "Pebbles";
                case ProductsModel.ProductTypes.Bark:
                    return "Bark";
                default:
                    return "";
            }
        }
    }
}