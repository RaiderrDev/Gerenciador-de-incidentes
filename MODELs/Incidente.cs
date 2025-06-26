using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Incidentes")]
public class Incidente
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Descricao { get; set; }
    public Prioridade Prioridade { get; set; }
    public DateTime DataAbertura { get; } = DateTime.Now;
    public Status Status { get; set; }

    public Incidente() { }

}