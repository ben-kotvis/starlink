using Api;
var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/blackbox"), "/app/blackbox-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/prometheus"), "/app/prometheus-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/prometheus"), "/app/prometheus-data", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "config/grafana"), "/app/grafana-config", true);
   CopyDirectory.Copy(Path.Combine(Directory.GetCurrentDirectory(), "data/grafana"), "/app/grafana-data", true);
     

app.Run();
