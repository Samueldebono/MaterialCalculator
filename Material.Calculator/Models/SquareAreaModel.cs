using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Material.Calculator.Models
{
    public class SquareAreaModel: MeasurementModel
    {
        //Square
        [DisplayName("Length")]
        public double? Length { get; set; }
        [DisplayName("Width")]
        public double? Width { get; set; }

        public MeasurementModel.MeasurementTypes MeasurementTypesLength { get; set; }
        public MeasurementModel.MeasurementTypes MeasurementTypesWidth { get; set; }
    }
}