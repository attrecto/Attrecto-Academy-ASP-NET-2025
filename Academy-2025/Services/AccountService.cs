using Academy_2025.Data;
using Academy_2025.Dtos;
using Academy_2025.Respositories;

namespace Academy_2025.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> LoginAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByEmailAsync(loginDto.Email);

            if (user != null && user.Password == loginDto.Password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
