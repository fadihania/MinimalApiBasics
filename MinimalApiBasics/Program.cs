var builder = WebApplication.CreateBuilder(args);

// Services/Dependency Injection
// builder.Services


var app = builder.Build();
app.Urls.Add("http://localhost:5000");

// Middlewares


app.MapGet("/", () => "Hello World!");
app.MapGet("/ucas", () => "ucas.edu.ps");
app.MapGet("/coddict", () => new
{
    Name = "Coddict",
    Url = "https://coddict.co",
    Started = 2023
});

app.MapPost("/students", () => "Student Created!");

app.Run();
