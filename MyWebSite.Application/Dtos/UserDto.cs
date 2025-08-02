namespace MyWebSite.Application.Dtos
{
    public record UserDto(Guid Id,
    bool IsActive,
    DateTime CreatedDate,
    DateTime UpdatedDate,
    string Name, 
    string Email, 
    IEnumerable<ImageDto>? Images);
   
}
