namespace MyWebSite.Domain.Entities.Blog
{
    public class BlogCategoryPost : BaseEntities
    {
        public BlogCategoryPost(string name) : base()
        { 
            Name = name;
        }
        public List<BlogPost> ListBlogPost { get; set; }

        public string Name { get; set; }
    }
}
