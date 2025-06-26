using Microsoft.EntityFrameworkCore;

public class IncidenteRepository : IRepositoryPersistencia<Incidente>
{
    private readonly IncidenteContext _incidenteContext;

    public IncidenteRepository(IncidenteContext incidente)
    {
        _incidenteContext = incidente;
    }

    public async Task<List<Incidente>> ListarTudo()
    {
        var incidentes = await _incidenteContext.Incidentes
        .ToListAsync();

        return incidentes;
    }

    public async Task<Incidente> Buscar(int id)
    {
        var incidenteBuscado = await _incidenteContext.Incidentes
        .Where(i => i.Id == id)
        .FirstOrDefaultAsync();

        return incidenteBuscado;
    }
    public async Task Atualizar(Incidente incidente, Status status)
    {
        incidente.Status = status;
        await _incidenteContext.SaveChangesAsync();
    }

    public async Task Salvar(Incidente incidente)
    {
        await _incidenteContext.Incidentes.AddAsync(incidente);
        await _incidenteContext.SaveChangesAsync();
    }

    public async Task Deletar(Incidente incidente)
    {
        _incidenteContext.Incidentes.Remove(incidente);
        await _incidenteContext.SaveChangesAsync();
    }
}