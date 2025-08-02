namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteSkillDescription: BaseEntities
    {
        public WebSiteSkillDescription(string title,string summary, string description, ICollection<Image> images) : base()
        {
            Title = title;
            Summary = summary;
            Description = description;
            Images = images;
        }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public ICollection<Image> Images { get; set; }

    }
}
