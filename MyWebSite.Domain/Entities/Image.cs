using MyWebSite.Domain.Entities.Admin;
using MyWebSite.Domain.Entities.Blog;
using MyWebSite.Domain.Entities.Cartoon;
using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Enum;

namespace MyWebSite.Domain.Entities
{
    public class Image : BaseEntities
    {
        public Image(string name, string path, ImageType type, float weight, float height, string alias) : base() 
        {
            Name = name;
            Path = path;
            Type = type;
            Height = height;
            Weigth = weight;
            Alias = alias;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public float Weigth { get; set; }
        public float Height { get; set; }
        public string Alias { get; set; }
        public ImageType Type { get; set; }

        public BlogPost BlogPost { get; set; }
        public WebSiteGeral WebSiteGeral { get; set; }
        public WebSiteSocialMedia WebSiteSocialMedia { get; set; }
        public WebSiteTestemonial WebSiteTestemonial { get; set; }

        public WebSiteknowledge WebSiteknowledge { get; set; }
        public WebSiteSkillDescription WebSiteSkillDescription { get; set; }
        public User User { get; set; }
        public CartoonPost CartoonPost { get; set; }

    }
}
