using BackendCoffeeNet.Dto.RegistroDTO;
using BackendCoffeeNet.Services.Contracts;

namespace BackendCoffeeNet.Services.Contracts;

public interface IUserService
{
    Task<ServiceResult> RegisterUserAsync(RegistroDTO registroDTO);
}