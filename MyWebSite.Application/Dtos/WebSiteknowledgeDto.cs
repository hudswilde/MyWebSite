namespace MyWebSite.Application.Dtos
{
    public record WebSiteknowledgeDto(
    Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDatestringstring,
    string Name,
    IEnumerable<ImageDto>? Images);
}
