using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<IncidenteContext>(options => options.UseSqlite("Data Source=IncidentesDb"));
builder.Services.AddScoped<IncidenteService>();
var app = builder.Build();
app.MapControllers();
app.Run();