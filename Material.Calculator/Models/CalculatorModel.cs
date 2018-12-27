using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Material.Calculator.Models
{
    public class CalculatorModel
    {
        [Required]
        [DisplayName("Depth of Area")]
       
        public double Depth { get; set; }

        //Square
        [DisplayName("Length of side")]
        public double? Length { get; set; }
        [DisplayName("Width of side")]
        public double? Width { get; set; }

        //Circle
        [DisplayName("Diameter of circle")]
        public double? Diameter { get; set; }

        //triangle
        [DisplayName("Length of edge 1")]
        public double? Edge1 { get; set; }

        [DisplayName("Length of edge 2")]
        public double? Edge2 { get; set; }

        [DisplayName("Length of edge 3")]
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