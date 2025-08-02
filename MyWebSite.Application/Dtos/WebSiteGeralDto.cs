namespace MyWebSite.Application.Dtos
{
    public record WebSiteGeralDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring,
    string Titulo,
    IEnumerable<ImageDto>? Images, 
    List<WebSiteSocialMediaDto> SocialMedias, 
    string Email);
}
