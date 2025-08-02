namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteSocialMedia : BaseEntities
    {
        public WebSiteSocialMedia(string title, ICollection<Image> images, string url )
        {
            Images = images;
            Title = title;
            Url = url;
        }
        public ICollection<Image> Images { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}
