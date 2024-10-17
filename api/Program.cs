using Api;
var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

//app.MapPost("/initialize", async (
//    CancellationToken cancellationToken) => 
//{
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/blackbox"), "/blackbox-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/prometheus"), "/prometheus-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/prometheus"), "/prometheus-data", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/grafana"), "/grafana-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/grafana"), "/grafana-data", true);
     
//});

app.Run();
