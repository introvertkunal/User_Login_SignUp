using User_Login_SignUp.src.User_Login_SignUp.Application.DTOs;
using User_Login_SignUp.src.User_Login_SignUp.Application.Interfaces;

namespace User_Login_SignUp.src.User_Login_SignUp.Application.UseCases
{
    public class LoginUserUseCase
    {
        // Dependency Injection

        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public LoginUserUseCase(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<string> Handle(LoginUserDto dto)
        {
            var user = await _userRepository.GetByEmailAsync(dto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            {
                return null;
            }


            return "";
        }

       






    }
}
