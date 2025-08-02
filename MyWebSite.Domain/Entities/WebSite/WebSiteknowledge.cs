namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteknowledge : BaseEntities
    {
        public WebSiteknowledge(string name, ICollection<Image> images) : base() {
            Name = name;
            Images = images;
        }
        public string Name { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
