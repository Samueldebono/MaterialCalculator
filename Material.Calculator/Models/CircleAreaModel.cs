using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Material.Calculator.Models
{
    public class CircleAreaModel: MeasurementModel
    {

   
        //Circle
        [DisplayName("Diameter")]
        public double? Diameter { get; set; }

        public MeasurementModel.MeasurementTypes MeasurementTypes { get; set; }
    }
}