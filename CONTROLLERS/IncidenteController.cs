using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

[ApiController]
[Route("api/[controller]")]
public class IncidenteController : ControllerBase
{
    private readonly IncidenteService _incidentService;

    public IncidenteController(IncidenteService service)
    {
        _incidentService = service;
    }

    [HttpGet("retornar")]
    public async Task<ActionResult<List<Incidente>>> RetornarTodos()
    {
        List<Incidente> lista = await _incidentService.RetornarIncidentes();
        return Ok(lista);
    }

    [HttpGet("buscar/{id}")]
    public async Task<ActionResult<Incidente>> BuscarIncidente([FromRoute] int id)
    {
        Incidente incidenteBuscado = await _incidentService.Buscar(id);

        if (incidenteBuscado == null)
        {
            return NotFound("Nenhum incidente encontrado com esse id.");
        }
        return Ok(incidenteBuscado);
    }

    [HttpPut("atualizar/{id}")]
    public async Task<ActionResult> AtualizarIncidente(int id, [FromBody] Status status)
    {
        Incidente incidente = await _incidentService.Atualizar(id, status);
        if (incidente == null)
        {
            return NotFound("Nenhum incidente encontrado com esse id.");
        }
        return Ok($"O status do incidente foi atualizado para: {incidente.Status}");
    }

    [HttpPost("salvar")]
    public async Task<ActionResult> SalvarIncidente([FromBody] Incidente incidente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        await _incidentService.Salvar(incidente);
        return Ok("Incidente salvo com sucesso.");

    }

    [HttpDelete("deletar/{id}")]
    public async Task<ActionResult> DeletarIncidente([FromRoute] int id)
    {
        var incidente = await _incidentService.Deletar(id);

        if (incidente == null)
        {
            return NotFound("Nenhum incidente encontrado com esse id.");
        }
        return Ok("Incidente deletado com sucesso.");
    }
}