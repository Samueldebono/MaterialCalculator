using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Material.Calculator.Models
{
    public class TriangleAreaModel: MeasurementModel
    {

        //triangle
        [DisplayName("Edge 1")]
        public double? Edge1 { get; set; }

        [DisplayName("Edge 2")]
        public double? Edge2 { get; set; }

        [DisplayName("Edge 3")]
        public double? Edge3 { get; set; }


        public MeasurementModel.MeasurementTypes MeasurementTypeEdge1 { get; set; }
        public MeasurementModel.MeasurementTypes MeasurementTypeEdge2 { get; set; }
        public MeasurementModel.MeasurementTypes MeasurementTypeEdge3 { get; set; }
    }
}