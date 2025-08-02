using MyWebSite.Application.DtoMapper;
using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces.Admin;
using MyWebSite.Domain.Entities.Admin;
using MyWebSite.Domain.Exception;
using MyWebSite.Domain.Interface.Repositories.Admin;

namespace MyWebSite.Application.Services.Admin
{
    public class UserService : CommumService<User>,IUserService
    {
        private readonly IUserRepositorie _userRepositorie;
        public UserService(IUserRepositorie userRepositorie) : base(userRepositorie) {
            _userRepositorie = userRepositorie;
        }
       

        public async Task<UserDto> AddUserAsync(AddUserCommand command)
        {

            // Validação simples
            if (string.IsNullOrWhiteSpace(command.Password) || string.IsNullOrWhiteSpace(command.Password))
                throw new ArgumentException("Email and Password must be provided.");

            var existingUser = await _userRepositorie.FindByEmailAsync(command.Email);
            
            if (existingUser != null)
                throw new ConflictException("A user with this email already exists.");

            var user = new User(
                command.Name,
                command.Email,
                BCrypt.Net.BCrypt.HashPassword(command.Password),
                null
            );

            await _userRepositorie.AddAsync(user);
            return user.ToDto();

        }

        public Task ForgotPasswordAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDto>> GetAllUserAsync()
        {
            var allUser = await _userRepositorie.GetAllAsync();
            
            if (allUser == null || allUser.Count() == 0)
            {
                throw new NotFoundException("Don't exist users");
            }

            return allUser.Select(x => x.ToDto());
        }

        public async Task<UserDto> GetUserAsync(Guid id)
        {

            var user = await _userRepositorie.FindByIdAsync(id);
            
            if (user == null) {
                throw new NotFoundException("Don't exist user with this id");
            }

            return user.ToDto();
        }

        public Task RedefinePasswordAsync(RedefinePasswordCommand redefinePasswordCommand)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UpdateUserCommand user)
        {
            throw new NotImplementedException();
        }
    }
}
