using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Application.Interfaces
{
    public interface ICommumService
    {
        Task Deactive(Guid id);
        Task Delete(Guid id);
        Task Active(Guid id);
    }
}
