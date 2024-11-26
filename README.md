# NADA Vehicle Pricing Plan Client

A .NET client for consuming the Microbilt NADA Vehicle Pricing API.

API page - https://developer.microbilt.com/api/NadaVehiclePricing

# Installation

`composer require AlexandrAndreev/NADA-Vehicle-Pricing-Plan`

# Quick Start

```
NADAVehiclePricingClient planClient = new NADAVehiclePricingClient("client_id", "client_secret");
```
# Configuration

`client_id` required

`client_secret` required

`EnvironmentType` optional (defaults to Production). Other option is Sandbox. 

# Usage
See https://developer.microbilt.com/api/NadaVehiclePricing for the necessary parameters to pass in to each function or see documentation in code
For report created request model 
```
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
```
You can Serialize model for use with extension method ```.ToJson()``` in 'Extensions.cs'

All responses for all requests 'JsonObject', for get JSON string You can use ```.ToString()``` method
