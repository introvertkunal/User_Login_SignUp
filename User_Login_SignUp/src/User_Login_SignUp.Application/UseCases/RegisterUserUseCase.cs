using User_Login_SignUp.src.User_Login_SignUp.Application.DTOs;
using User_Login_SignUp.src.User_Login_SignUp.Application.Interfaces;
using User_Login_SignUp.src.User_Login_SignUp.Domain.Entities;
using BCrypt.Net;

namespace User_Login_SignUp.src.User_Login_SignUp.Application.UseCases
{
    public class RegisterUserUseCase
    { 
        // Dependency Injection 

        private readonly IUserRepository _userRepository;

        public RegisterUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(RegisterUserDto dto)
        {
            // Check if user already exists
            var existing = await _userRepository.GetByEmailAsync(dto.Email);
            if(existing != null)
            {
                return false;
            }

            //Create new user              

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
           
            // Save user to repository

            await _userRepository.AddUser(user);
            return true;
        }

    }
}
