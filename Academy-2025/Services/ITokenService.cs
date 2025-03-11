using Academy_2025.Data;

namespace Academy_2025.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
