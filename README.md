# Minimal API Basics
A sample application that shows the basics of building REST API using the new Minimal API endpoints and basic routing

**Check commits for steps and how to apply different concepts**

- New project
  + dotnet new web
  + ASP.NET Core Empty
- Web Server:
  + Kestrel
  + IIS, Apache, Nginx not required, but can be used
- Server URL
  + `Properties/launchSettings.json`
  + `app.Urls.Add("http://localhost:5000")`
- Routing
  + Request: URL/Method
  + `MapGet()`, `MapPost()`, `MapPut()`, `MapDelete()`
  + Response (default): `string` => Text, `object` => JSON