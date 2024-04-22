This is a .NET WebAPI for UK's reading rainfall data. 
It will only contain one endpoint for retrieving a station's rainfall measurements limited by user defined count.

This solution contains two projects:
1. DevPartnersRainfall - main API project
   **Dependencies - Packages:**
   1. AutoMapper 12.0.1
   2. AutoMapper.Extensions.Microsoft.DependecyInjection 12.0.1
   3. Microsoft.EntityFrameworkCore 8.0.4
   4. Newtonsoft.Json 13.0.3
   5. Swashbuckle.AspNetCore 6.4.0
   6. Swashbuckle.AspNetCore.Annotations 6.5.0
2. RainfallTest - xUnit project
   **Dependencies - Packages:**
   1. Microsoft.NET.Test.Sdk 17.6.0
   2. Moq 4.20.70
   3. xunit 2.4.2
   4. xunit.runner.visualstudio 2.4.5

For nugget packages, if went missing, please run the commands below.
* Re-install all nuget at once: **Update-Package –reinstall**
* Install per nugget: **Update-Package –reinstall -ProjectName App**

How to RUN the project.
Upon rebuilding the entire solution successfully, please run the DevPartnersRainfall by hitting **F5** and test the endpoint from Swagger UI.
For test project, kindly right click on the test method and hit **Run Tests**.
