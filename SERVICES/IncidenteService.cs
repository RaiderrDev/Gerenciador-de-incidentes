public class IncidenteService
{
    private readonly IRepositoryPersistencia<Incidente> _incidenteRepository;

    public IncidenteService(IRepositoryPersistencia<Incidente> incidenteRepository)
    {
        _incidenteRepository = incidenteRepository;
    }

    public async Task<List<Incidente>> RetornarIncidentes()
    {
        var incidentes = await _incidenteRepository.ListarTudo();
        return incidentes;
    }

    public async Task<Incidente> Buscar(int id)
    {
        var incidenteBuscado = await _incidenteRepository.Buscar(id);
        return incidenteBuscado;
    }

    public async Task<Incidente> Atualizar(int id, Status status)
    {
        var incidenteBuscado = await _incidenteRepository.Buscar(id);

        if (incidenteBuscado == null)
        {
            return incidenteBuscado;
        }
        await _incidenteRepository.Atualizar(incidenteBuscado, status);
        return incidenteBuscado;
    }

    public async Task<Incidente> Deletar(int id)
    {
        var incidenteBuscado = await _incidenteRepository.Buscar(id);

        if (incidenteBuscado == null)
        {
            return incidenteBuscado;
        }
        await _incidenteRepository.Deletar(incidenteBuscado);
        return incidenteBuscado;
    }

    public async Task Salvar(Incidente incidente)
    {
        await _incidenteRepository.Salvar(incidente);
    }
}