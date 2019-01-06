using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Material.Calculator.Models
{
    public class CalculatorModel: MeasurementModel
    {
        [Required]
        [DisplayName("Depth")]
       
        public double Depth { get; set; }

        public MeasurementModel.MeasurementTypes DepthMeasurementTypes { get; set; }

        public SquareAreaModel Square { get; set; }
        public CircleAreaModel Circle { get; set; }
        public TriangleAreaModel Triangle { get; set; }

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