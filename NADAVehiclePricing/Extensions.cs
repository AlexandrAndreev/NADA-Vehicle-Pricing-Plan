using NADAVehiclePricing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NADAVehiclePricing
{
    public static class VehiclePricingReportRequstModelExtensions
    {
        public static string ToJson(this VehiclePricingReportRequstModel val)
        {
            return JsonSerializer.Serialize<VehiclePricingReportRequstModel>(val);
        }
    }

    public static class EnvironmentTypeExtensions
    {
        public static string ToDescriptionString(this EnvironmentType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }

    public enum EnvironmentType
    {
        [Description("https://api.microbilt.com")]
        Production,
        [Description("https://apitest.microbilt.com")]
        Sandbox
    }
}
