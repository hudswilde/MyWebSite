namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteDescription : BaseEntities
    {
        public WebSiteDescription(string title, string subTitle, string description, List<WebSiteSkillDescription> listSkillDescription ) {
            Title = title;
            SubTitle = subTitle;
            Description = description;
            ListSkillDescription = listSkillDescription;
        }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public List<WebSiteSkillDescription>? ListSkillDescription { get; private set; }
    }
}
