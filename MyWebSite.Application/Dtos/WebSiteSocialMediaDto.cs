namespace MyWebSite.Application.Dtos
{
    public record WebSiteSocialMediaDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestring,
    string Title,
    IEnumerable<ImageDto>? Images,
    string Url
    );
    
}
