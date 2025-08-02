using System;

namespace MyWebSite.Domain.Exception
{
    public class NotFoundException : System.Exception
    {
         public NotFoundException(string msg) : base(msg) { }
    }
}
