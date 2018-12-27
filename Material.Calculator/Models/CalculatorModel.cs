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
        [DisplayName("Depth of Area")]
        public double Depth { get; set; }

        //Square
        [DisplayName("Length of Area")]
        public double? Length { get; set; }
        [DisplayName("Width of Area")]
        public double? Width { get; set; }

        //Circle
        [DisplayName("Length of Area")]
        public double? Diameter { get; set; }

        //triangle
        [DisplayName("Width of Area")]
        public double? Edge1 { get; set; }

        [DisplayName("Depth of Area")]
        public double? Edge2 { get; set; }

        [DisplayName("Depth of Area")]
        public double? Edge3 { get; set; }




        [DisplayName("Product type")]
        public ProductsModel.ProductTypes ProductType { get; set; }

        [DisplayName("Cubes")]
        public double ResultsCubes { get; set; }

        [DisplayName("Tonnes")]
        public double ResultsTonnes { get; set; }

        public AmountTypes AmountType { get; set; }
        [DisplayName("Type of Area")]
        public AreaTypes AreaType { get; set; }

        public enum AreaTypes
        {
            Square = 0,
            Circle = 1,
            Triangle = 2

        }

        public enum AmountTypes
        {
            CubicMeter = 0,
            Tonne = 1
        }
    }




    

}