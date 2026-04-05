using BackendCoffeeNet.Dto.RegistroDTO;
using BackendCoffeeNet.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BackendCoffeeNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegistroDTO registroDTO)
    {
        // Validar el modelo
        if (!ModelState.IsValid)
        {
            var errores = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);

            return BadRequest(new ServiceResult(false, "Datos Inválidos", string.Join(" | ", errores)));
        }

        // Ejecutar lógica de negocio
        var result = await _userService.RegisterUserAsync(registroDTO);

        // Mapear resultado a códigos HTTP
        if (result.IsSuccess)
            return StatusCode(201, result);

        // error 409 si datos ya existen, de lo contrario error 400
        var esConflicto = result.Message.Contains("correo", StringComparison.OrdinalIgnoreCase) ||
                          result.Message.Contains("usuario", StringComparison.OrdinalIgnoreCase);
        
        return esConflicto ? StatusCode(409, result) : BadRequest(result);
    }
}