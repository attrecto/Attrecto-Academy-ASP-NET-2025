using Academy_2025.Data;
using Academy_2025.Dtos;

namespace Academy_2025.Services
{
    public interface IAccountService
    {
        Task<User?> LoginAsync(LoginDto loginDto);
    }
}
