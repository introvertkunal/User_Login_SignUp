﻿

namespace User_Login_SignUp.src.User_Login_SignUp.Domain.Entities
{
    public class User

    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string Name { get; set; }
        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    }
}
