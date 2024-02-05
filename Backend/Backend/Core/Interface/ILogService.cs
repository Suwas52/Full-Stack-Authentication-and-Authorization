using Backend.Core.DTOs.Log;
using System.Security.Claims;

namespace Backend.Core.Interface
{
    public interface ILogService
    {
        Task SaveNewLog(string UserName, string Description);

        Task<IEnumerable<GetLogDto>> GetLogsAsync();

        Task<IEnumerable<GetLogDto>> GetMyLogsAsync(ClaimsPrincipal User);

    }
}
