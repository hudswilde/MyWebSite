namespace MyWebSite.Domain.Entities.Cartoon
{
    public class CartoonPost : BaseEntities
    {
        public CartoonPost(string title, string subTitle, string cartoon, string description,ICollection<Image> images, List<CartoonCategoryPost> categoryPost): base()
        { 
            this.Description = description;
            this.Title = title;
            this.SubTitle = subTitle;
            this.Cartoon = cartoon;
            this.CategoryPost = categoryPost;
            this.Images = images;
        }

        List<CartoonCategoryPost> CategoryPost { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Cartoon { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Description { get; set; }

    }
}
