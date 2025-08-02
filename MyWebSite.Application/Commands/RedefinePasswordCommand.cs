namespace MyWebSite.Application.Dtos
{
    public record RedefinePasswordCommand(Guid Id, string OldPassword, string NewPassword);
}
