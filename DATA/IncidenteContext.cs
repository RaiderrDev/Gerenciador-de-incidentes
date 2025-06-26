using Microsoft.EntityFrameworkCore;

public class IncidenteContext : DbContext
{
    public IncidenteContext(DbContextOptions<IncidenteContext> options) : base(options)
    {

    }

    public DbSet<Incidente> Incidentes { get; set; }
}
