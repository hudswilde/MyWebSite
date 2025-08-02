namespace MyWebSite.Domain.Entities.Blog
{
    public class BlogPost : BaseEntities
    {
        public BlogPost(string title, string subTitle, string description, List<BlogCategoryPost> listCategoryPost, ICollection<Image> images) : base() {
            ListCategoryPost = listCategoryPost;
            Title = title;
            Images = images;
            Description = description;
        }

        public List<BlogCategoryPost> ListCategoryPost { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Description { get; set; }
    }
}
