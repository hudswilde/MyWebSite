namespace MyWebSite.Domain.Entities.Cartoon
{
    public class CartoonCategoryPost : BaseEntities
    {
        public CartoonCategoryPost(string name  )
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
