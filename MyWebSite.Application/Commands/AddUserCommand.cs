namespace MyWebSite.Application.Dtos
{
    public record AddUserCommand(string Name, string Email, string Password, ImageDto Photo);
    
}
