using MyWebSite.Application.Dtos;

namespace MyWebSite.Application.Interfaces.Admin
{
    public interface IUserService: ICommumService
    {
        Task<UserDto> AddUserAsync(AddUserCommand command);
        Task<UserDto> GetUserAsync(Guid id);
        Task<IEnumerable<UserDto>> GetAllUserAsync();
        Task UpdateUserAsync(UpdateUserCommand command);
        Task ForgotPasswordAsync(Guid id);
        Task RedefinePasswordAsync(RedefinePasswordCommand command);
    }
}
