using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Material.Calculator.Utility
{
    public static class GlobalConversions
    {
        public static double SandRate { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:SandConvertRate"]);

        public static double SoilRate { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:SoilConvertRate"]);

        public static double TurfUnderlaySoil { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:TurfUnderlaySoilConvertRate"]);

        public static double GardenMix { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:GardenMixConvertRate"]);

        public static double BarkRate { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:BarkConvertRate"]);

        public static double PebbleRate { get; } =
            double.Parse(ConfigurationSettings.AppSettings["Calculator:PebblesConvertRate"]);
    }

}