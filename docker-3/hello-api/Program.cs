var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", 
    () => 
    $"I think you wanted /helloworld");


app.MapGet("/helloworld", 
    () => 
    $"Hello from API at {System.DateTime.Now} on the {System.Environment.MachineName}");

app.Run();