namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteGeral : BaseEntities
    {
        public WebSiteGeral(string titulo, ICollection<Image> images, List<WebSiteSocialMedia> socialMedias, string email) : base() {
            Titulo = titulo;
            Images = images;
            SocialMedias = socialMedias;
            Email = email;
        }
        public string Titulo { get; private set; }
        public ICollection<Image> Images { get; private set; }
        List<WebSiteSocialMedia> SocialMedias { get; set; }
        public string Email { get; set; }
    }
}
