using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADAVehiclePricing.Model
{
    public class VehiclePricingReportRequstModel
    {
        public string Mileage { get; set; }
        public AutomobileInfo AutomobileInfo { get; set; }

    }

    public class AutomobileInfo
    {
        public string Make { get; set; }
        public string RegState { get; set; }
        public string VIN { get; set; }
        public string Series { get; set; }
        public string ModelYear { get; set; }
    }
}
