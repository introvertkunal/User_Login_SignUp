namespace User_Login_SignUp.src.User_Login_SignUp.Domain.Entities
{
    public class Attendance
    {
       
            public Guid Id { get; set; } = Guid.NewGuid();

            public Guid UserId { get; set; }

            public User User { get; set; }

            public DateTime LoginTime { get; set; }
            public DateTime? LogoutTime { get; set; }



        
    }
}
