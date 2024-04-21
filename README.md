This is a .NET WebAPI for UK's reading rainfall data. 
It will only contain one endpoint for retrieving a station's rainfall measurements limited by user defined count.

This solution contains two projects:
1. DevPartnersRainfall - main API project
2. RainfallTest - xUnit project

For nugget packages, if went missing, please run the commands below.
* Re-install all nuget at once: **Update-Package –reinstall**
* Install per nugget: **Update-Package –reinstall -ProjectName App**

How to RUN the project.
Upon rebuilding the entire solution successfully, please run the DevPartnersRainfall by hitting **F5** and test the endpoint from Swagger UI.
For test project, kindly right click on the test project and hit **Run Tests**.
