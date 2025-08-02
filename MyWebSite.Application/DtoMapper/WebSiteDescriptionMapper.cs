using MyWebSite.Application.Dtos;
using MyWebSite.Domain.Entities.WebSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Application.DtoMapper
{
    public static class WebSiteDescriptionMapper
    {
        public static WebSiteDescriptionDto ToDto(this WebSiteDescription webSiteDescription)
        {
            return new WebSiteDescriptionDto(webSiteDescription.Id, webSiteDescription.IsActive, webSiteDescription.CreatedDate, webSiteDescription.UpdateDate, webSiteDescription.Title, webSiteDescription.SubTitle, webSiteDescription.Description, webSiteDescription.ListSkillDescription.Select(x=> x.ToDto()));
        }
    }
}
