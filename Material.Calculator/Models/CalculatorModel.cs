using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Material.Calculator.Models
{
    public class CalculatorModel
    {
        [DisplayName("Length of Area")]
        public double Length { get; set; }
        [DisplayName("Width of Area")]
        public double Width { get; set; }
        [DisplayName("Depth of Area")]
        public double Depth { get; set; }
        [DisplayName("Product type")]
        public ProductsModel.ProductTypes ProductType { get; set; }

        [DisplayName("Cubes")]
        public double ResultsCubes { get; set; }

        [DisplayName("Tonnes")]
        public double ResultsTonnes { get; set; }

        public AmountTypes AmountType { get; set; }


    }

        public enum AmountTypes
        {
            CubicMeter =0,
            Tonne = 1
        }
    

}