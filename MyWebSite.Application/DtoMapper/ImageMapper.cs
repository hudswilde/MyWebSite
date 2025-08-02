using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities;

namespace MyWebSite.Application.DtoMapper
{
    public static class ImageMapper
    {
        public static ImageDto ToDto(this Image image) {
            return new ImageDto(image.Id,image.Name,image.Path,image.Type,image.Weigth,image.Height, image.Alias);
        }
    }
}
