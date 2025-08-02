using MyWebSite.Application.DtoMapper;
using MyWebSite.Application.Dtos;
using MyWebSite.Application.Interfaces.WebSite;
using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Exception;
using MyWebSite.Domain.Interface.Repositories.WebSite;

namespace MyWebSite.Application.Services.WebSite
{
    public class WebSiteDescriptionService : CommumService<WebSiteDescription>,IWebSiteDescriptionService
    {
        private readonly IWebSiteDescriptionRepositorie _webSiteDescriptionRepositorie;
        public WebSiteDescriptionService(IWebSiteDescriptionRepositorie webSiteDescriptionRepositorie) : base(webSiteDescriptionRepositorie) {
            _webSiteDescriptionRepositorie = webSiteDescriptionRepositorie;
        }

        public async Task AddDescriptionAsync(AddWebSiteDescriptionCommand command)
        {
            WebSiteDescription webSiteDescription = new WebSiteDescription(command.Title, command.SubTitle, command.Description, null);
            await _webSiteDescriptionRepositorie.AddAsync(webSiteDescription);
        }

        public async Task AlterDescriptionAsync(UpdateWebSiteDescriptionCommand command)
        {
            var entity = await _webSiteDescriptionRepositorie.FindByIdAsync(command.Id);

            if (entity == null)
            {
                throw new NotFoundException("not found for the given ID.");
            }

            entity.Title = command.Title;
            entity.SubTitle = command.SubTitle;
            entity.Description = command.Description;
            await _webSiteDescriptionRepositorie.SaveChanges();
        }
       

        public async Task<IEnumerable<WebSiteDescriptionDto>> GetAllActiveDescriptionAsync()
        {
            var listWebSiteDescription = await _webSiteDescriptionRepositorie.GetAllActiveAsync();
            return listWebSiteDescription.Select(x => x.ToDto());
        }

        public async Task<IEnumerable<WebSiteDescriptionDto>> GetAllDescriptionAsync()
        {
            var listWebSiteDescription = await _webSiteDescriptionRepositorie.GetAllAsync();
            return listWebSiteDescription.Select(x => x.ToDto());
        }

        public async Task<WebSiteDescriptionDto> GetDescriptionByIdAsync(Guid id)
        {
            var webSiteDescription = await _webSiteDescriptionRepositorie.FindByIdAsync(id);
            
            if (webSiteDescription == null)
            {
                throw new NotFoundException("not found for the given ID.");
            }

            return webSiteDescription.ToDto();
        }
    }
}
