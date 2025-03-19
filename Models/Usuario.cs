using System.ComponentModel.DataAnnotations;

namespace ProyectoBase.Models;

public class Usuario
{
    [Key]
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public DateTime CreatedAt { get; set; }
}