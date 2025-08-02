namespace MyWebSite.Application.Commands
{
    public record UpdateUserCommand(Guid Id, string Name, string Email,string Photo);
    
}
