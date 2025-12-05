## FishingLog Minimal API (ASP.NET Core)

FishingLog-MinimalAPI is a lightweight **ASP.NET Core Minimal API** that exposes RESTful endpoints related to fishing data.  
It’s a learning/portfolio project that demonstrates how to:

- Configure and run a Minimal API in .NET
- Define endpoints using concise route mappings
- Work with models and basic request/response patterns
- Use an `.http` file to quickly test endpoints

The project is themed around fishing to match a broader set of fishing-related apps in this portfolio (such as Catch Keeper and FishingPredictor-MLNET).

---

## 🚀 Features

- ✅ **Minimal API style** — no traditional controllers required for core endpoints  
- ✅ Sample endpoints for fishing-related data (and the default WeatherForecast sample)  
- ✅ Strongly-typed models under `Models/`  
- ✅ Simple configuration via `appsettings.json`  
- ✅ `.http` file (`FishingLogMinimalApi.http`) included for quick testing with Visual Studio or VS Code  

> Note: This project focuses on API structure and Minimal API syntax.  
> It can easily be extended to use **EF Core + a real SQL database** if desired.

---

## 🧱 Tech Stack

- **Language:** C#  
- **Framework:** ASP.NET Core Minimal API  
- **Runtime:** .NET 6+  
- **Tools:** Visual Studio / `dotnet` CLI  
- **Style:** REST-style JSON endpoints  

---

## 📂 Project Structure

```text
FishingLog-MinimalAPI/
│
├── Controllers/                 # (If used) traditional controllers or additional API logic
├── Models/                      # Request/response and domain models
├── Properties/
│   └── launchSettings.json      # Local launch profiles
│
├── appsettings.json             # App configuration
├── appsettings.Development.json # Dev-only configuration
├── FishingLogMinimalApi.csproj  # Project file
├── FishingLogMinimalApi.sln     # Solution file
├── FishingLogMinimalApi.http    # HTTP test file for endpoints
├── Program.cs                   # Minimal API bootstrap & endpoint mappings
└── WeatherForecast.cs           # Example model (template / sample endpoint)
```
## ▶️ Running the API
Prerequisites

.NET 6+ SDK installed
Visual Studio 2022 or later, or VS Code with C# extensions

Run with dotnet CLI
git clone https://github.com/Maxtheflash/FishingLog-MinimalAPI.git
cd FishingLog-MinimalAPI
dotnet run

The API will start on a local port (shown in the console).
Test endpoints
You can either:
- Use the built-in FishingLogMinimalApi.http file in Visual Studio / VS Code to send requests, or
- Use tools like Postman / curl to hit the exposed routes.
Typical routes might include:
- GET /weatherforecast – sample template endpoint
- GET /fish / POST /fish etc. – fishing-related routes (depending on how you extend the project)

## Future Enhancements
- Add a FishingTrip model with species, length, weight, location, and conditions
- Persist data using Entity Framework Core + SQL Server
- Add validation and error handling middleware
- Add authentication/authorization for protected endpoints
- Connect this API to the Catch Keeper MVC front-end or a mobile app

👤 Author
Branden Maxwell
Software Developer (.NET | Web APIs | ML.NET)
GitHub: @Maxtheflash
