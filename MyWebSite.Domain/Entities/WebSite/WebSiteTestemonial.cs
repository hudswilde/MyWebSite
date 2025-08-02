namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteTestemonial : BaseEntities
    {
        public WebSiteTestemonial(string name, string description, ICollection<Image> images, string role, string font) : base() { 
            Name = name; 
            Description = description;
            Images = images;
            Role = role;
            Font = font;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Role { get; set; }
        public string Font { get; set; }
       
    }
}
