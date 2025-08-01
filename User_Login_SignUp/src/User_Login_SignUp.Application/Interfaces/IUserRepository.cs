using User_Login_SignUp.src.User_Login_SignUp.Domain.Entities;  

namespace User_Login_SignUp.src.User_Login_SignUp.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);

        Task<User> GetByIdAsync(Guid id);

        Task AddUser(User user);
    }
}
