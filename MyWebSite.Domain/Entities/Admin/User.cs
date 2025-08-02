namespace MyWebSite.Domain.Entities.Admin
{
    public class User: BaseEntities
    {
        public User(string name, string email, string password, ICollection<Image>? images) : base()
        {
            Name = name;
            Email = email;
            Password = password;
            Images = images;
        }

       
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public ICollection<Image>? Images { get; set; }
    }
}
