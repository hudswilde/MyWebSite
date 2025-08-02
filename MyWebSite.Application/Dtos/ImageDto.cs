using MyWebSite.Domain.Enum;

namespace MyWebSite.Application.Dtos
{
    public record ImageDto(Guid Id, string Name, string Path, ImageType Type, float Weight, float Height, string Alias);
    
}
