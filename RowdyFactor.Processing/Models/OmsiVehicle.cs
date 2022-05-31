using System;
using System.Collections.Generic;
using System.Text;

namespace RowdyFactor.Processing.Models
{
    public class OmsiVehicle
    {
        public string FilePath { get; set; }
        public OmsiVehicleName Name { get; set; } = new OmsiVehicleName();
        public OmsiRowdyFactor RowdyFactor { get; set; } = null;

    }
    public class OmsiRowdyFactor {

        public OmsiRowdyFactor() { }
        public OmsiRowdyFactor(double from, double to)
        {
            From = from;
            To = to;
        }

        public double? From { get; set; }
        public double? To { get; set; }
    }
    public class OmsiVehicleName
    {
        public string Brand { get; set; } = "Undefined";
        public string CarModel { get; set; } = "Undefined";

        public string CarType { get; set; } = "";
           
    }
}
