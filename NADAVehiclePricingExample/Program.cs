using NADAVehiclePricing;
using NADAVehiclePricing.Model;
//Use You credentials from https://developer.microbilt.com/
//NADAVehiclePricingClient planClient = new NADAVehiclePricingClient("123", "123", EnvironmentType.Sandbox);
NADAVehiclePricingClient planClient = new NADAVehiclePricingClient("8LpEcVXfS4P3YCOpPKrzhl81GczUASpP", "St7o6DvHBLP08f9T", EnvironmentType.Sandbox);
Console.WriteLine("*******************************************");
Console.WriteLine("Authorization = {0}", planClient.Authorization);
Console.WriteLine("*******************************************");
Console.WriteLine("*******************************************");
Console.WriteLine("GetStates = {0}", planClient.VehiclePricingAPIClient.GetStates().ToString());
Thread.Sleep(2000);
Console.WriteLine("*******************************************----------*******************************************");
Console.WriteLine("GetYears = {0}", planClient.VehiclePricingAPIClient.GetYears().ToString());
Thread.Sleep(2000);
Console.WriteLine("*******************************************----------*******************************************");
Console.WriteLine("GetGetMake = {0}", planClient.VehiclePricingAPIClient.GetGetMake(2020).ToString());
Thread.Sleep(2000);
Console.WriteLine("*******************************************----------*******************************************");
Console.WriteLine("GetGetSeries = {0}", planClient.VehiclePricingAPIClient.GetGetSeries(2020, 41).ToString());
Thread.Sleep(2000);
Console.WriteLine("*******************************************----------*******************************************");
Console.WriteLine("GetBody = {0}", planClient.VehiclePricingAPIClient.GetBody(2020, 41, 723).ToString());
Thread.Sleep(2000);
Console.WriteLine("*******************************************----------*******************************************");



VehiclePricingReportRequstModel reqMode = new VehiclePricingReportRequstModel()
{
    Mileage = "9183",
    AutomobileInfo = new AutomobileInfo()
    {
        Make = "AUDI",
        RegState = "6",
        VIN = "WAUFACF56PA046204",
        Series = "A5",
        ModelYear = "2023"

    }
};

var report = planClient.VehiclePricingAPIClient.GetReport(reqMode.ToJson());
Console.WriteLine("GetReport = {0}", report.ToString());

Console.ReadKey();