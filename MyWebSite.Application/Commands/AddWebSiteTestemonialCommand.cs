namespace MyWebSite.Application.Dtos
{
    public record AddWebSiteTestemonialCommand(string Name, string Description, IEnumerable<ImageDto> Images, string Role, string Font);
    
}
