using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class IncidenteContextFactory : IDesignTimeDbContextFactory<IncidenteContext>
{
    public IncidenteContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<IncidenteContext>();

        // Altere a string de conexão conforme necessário
        optionsBuilder.UseSqlite("Data Source=IncidentesDb");

        return new IncidenteContext(optionsBuilder.Options);
    }
}
