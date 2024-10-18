using Api;
var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", async() =>
{
   string fileName = Path.Combine(Directory.GetCurrentDirectory(), "index.html");
        string fileContents = await System.IO.File.ReadAllTextAsync(fileName);
    return Results.Content(fileContents, "text/html");
});

app.MapPost("/initialize",  (
    CancellationToken cancellationToken) => 
{
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/blackbox"), "/app/blackbox-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/prometheus"), "/app/prometheus-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/prometheus"), "/app/prometheus-data", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/grafana/provisioning"), "/app/grafana-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/grafana"), "/app/grafana-data", true);
});

app.Run();
