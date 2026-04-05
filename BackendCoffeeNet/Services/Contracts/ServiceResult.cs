namespace BackendCoffeeNet.Services.Contracts;

public record ServiceResult(bool IsSuccess, string Message, string? Data = null)
{
    
}