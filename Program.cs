// These create WebApplication Builder and WebApplication with preconfigured defaults
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // creates an HTTP GET endpoint / which returns Hello World! 

app.Run(); // runs the app

