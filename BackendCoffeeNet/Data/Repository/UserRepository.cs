using BackendCoffeeNet.Data.Repository.IRepository;
using BackendCoffeeNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendCoffeeNet.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDBContext _context;
    public UserRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsByEmailAsync(string email)
    {
        return await _context.Usuarios.AnyAsync(u => u.Email == email);
    }

    public async Task<bool> ExistsByUsernameAsync(string username)
    {
        return await _context.Usuarios.AnyAsync(u => u.NombreUsuario == username);
    }

    public async Task<bool> AddAsync(Usuarios usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        return await _context.SaveChangesAsync() > 0;
    }
}