using User_Login_SignUp.src.User_Login_SignUp.Application.DTOs;

namespace User_Login_SignUp.src.User_Login_SignUp.Application.Interfaces
{
    public interface IAttendanceService
    {
      Task<bool> RecordLoginAsync(Guid userId);
      Task<bool> RecordLogoutAsync(Guid userId);

      Task<List<AttendanceSummaryDto>> GetAttendanceAsync(Guid userId);
    }
}
