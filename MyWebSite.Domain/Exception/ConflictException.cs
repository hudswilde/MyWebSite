namespace MyWebSite.Domain.Exception
{
    public class ConflictException : System.Exception
    {
        public ConflictException(string msg) : base(msg) { }
       
    }
}
