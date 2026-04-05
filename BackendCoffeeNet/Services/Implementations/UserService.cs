using BackendCoffeeNet.Data.Repository.IRepository;
using BackendCoffeeNet.Dto.RegistroDTO;
using BackendCoffeeNet.Models;
using BackendCoffeeNet.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace BackendCoffeeNet.Services.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<Usuarios> _passwordHasher;

    public UserService(IUserRepository userRepository, IPasswordHasher<Usuarios> passwordHasher)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
    }
    
    public async Task<ServiceResult> RegisterUserAsync(RegistroDTO registroDTO)
    {
        // Generar el nombre de usuario
        var nombreUsuario = $"{registroDTO.Nombre.ToLower()}.{registroDTO.Apellido.ToLower()}";

        // Validación de duplicados vía Repositorio
        if (await _userRepository.ExistsByEmailAsync(registroDTO.Email))
           return new ServiceResult(false, "El correo electrónico ya está registrado.");

        if (await _userRepository.ExistsByUsernameAsync(nombreUsuario))
           return new ServiceResult(false, "El nombre de usuario ya está en uso. Intente con otro nombre y aepellido.");

        // Hash de contraseña
        var passwordHash = _passwordHasher.HashPassword(null!, registroDTO.Password);

        // Crear y guardar el ususario
        var usuario = new Usuarios
        {
            Nombre = registroDTO.Nombre,
            Apellido = registroDTO.Apellido,
            Email = registroDTO.Email,
            Telefono = registroDTO.Telefono,
            NombreUsuario = nombreUsuario,
            Password = passwordHash,
            Rol = "Cliente",
            Estado = true,
            Fecha_Registro = DateTime.UtcNow
        };

        var success = await _userRepository.AddAsync(usuario);

        return success
            ? new ServiceResult(true, "Usuario regustrado exitosamente.", usuario.Id_usuario.ToString())
            : new ServiceResult(false, "Error al registrar el usuario. Intente nuevamente.");
    }
    
}