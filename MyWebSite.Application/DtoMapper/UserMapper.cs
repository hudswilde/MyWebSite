using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities.Admin;

namespace MyWebSite.Application.DtoMapper
{
    public static class UserMapper
    {
        public static UserDto ToDto(this User user)
        {
            return new UserDto(user.Id, user.IsActive, user.CreatedDate, user.UpdateDate, user.Name, user.Email, user.Images.Select(x=> x.ToDto()));
        }
    }
}
