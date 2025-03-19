using Microsoft.EntityFrameworkCore;
using ProyectoBase.Data;
using ProyectoBase.Models;

namespace ProyectoBase.Services;

public class UsuarioService
{
    private readonly DataContext _context;

    public UsuarioService(DataContext context)
    {
        _context = context;
    }

    //obtener todos los usuarios
    public async Task<List<Usuario>> ObtenerUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }

    //obtener un usuario por id
    public async Task<Usuario?> ObtenerUsuarioPorId(Guid id)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
    }
    
    //crear un usuario 
    public async Task<Usuario> CrearUsuario(Usuario usuario )
    {
        usuario.Id = Guid.NewGuid();
        usuario.CreatedAt = DateTime.UtcNow;

        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        
        return usuario;
    }

}