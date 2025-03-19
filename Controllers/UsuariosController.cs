using Microsoft.AspNetCore.Mvc;
using ProyectoBase.Models;
using ProyectoBase.Services;

namespace TestWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UsuariosController : ControllerBase
{
    private readonly UsuarioService _usuarioService;

    public UsuariosController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Usuario>>> ObtenerUsuarios()
    {
        var usuarios = await _usuarioService.ObtenerUsuarios();
        return Ok(usuarios);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> ObtenerUsuarioPorId(Guid id)
    {
        var usuario = await _usuarioService.ObtenerUsuarioPorId(id);
        if (usuario == null) return NotFound("Usuario no encontrado");

        return Ok(usuario);
    }
}