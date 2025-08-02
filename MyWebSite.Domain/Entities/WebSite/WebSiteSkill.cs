namespace MyWebSite.Domain.Entities.WebSite
{
    public class WebSiteSkill : BaseEntities
    {  
        public WebSiteSkill(float percent, string name) : base()
        {
            Percent = percent;
            Name = name;
        }
        public float Percent { get; private set; }
        public string Name { get; private set; }
      
    }
}
