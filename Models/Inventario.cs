using System.ComponentModel.DataAnnotations;

namespace ProyectoBase.Models;

public class Inventario
{
    [Key]
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public string? ImagenUrl { get; set; }
    public DateTime FechaCreacion { get; set; }
}