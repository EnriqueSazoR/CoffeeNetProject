using BackendCoffeeNet.Dto.RegistroDTO;
using BackendCoffeeNet.Models;

namespace BackendCoffeeNet.Data.Repository.IRepository
{

    
    public interface IUserRepository
    {
        Task<bool> ExistsByEmailAsync(string email);
        Task<bool> ExistsByUsernameAsync(string username);
        Task<bool> AddAsync(Usuarios usario);
    }
}