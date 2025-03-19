using Microsoft.EntityFrameworkCore;
using ProyectoBase.Models;

namespace ProyectoBase.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Inventario> Inventario { get; set; }
    
}