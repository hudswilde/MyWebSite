using MyWebSite.Application.Interfaces;
using MyWebSite.Domain.Entities;
using MyWebSite.Domain.Entities.WebSite;
using MyWebSite.Domain.Exception;
using MyWebSite.Domain.Interface.Repositories;

namespace MyWebSite.Application.Services
{
    public class CommumService<T>: ICommumService where T : BaseEntities
    {

        private readonly IBaseRepositories<T> _repositorie;
        public CommumService(IBaseRepositories<T> repositorie)
        {
            _repositorie = repositorie;
        }
        

        public async Task Active(Guid id)
        {
            var entity = await _repositorie.FindByIdAsync(id);

            if (entity == null)
            {
                throw new NotFoundException("not found for the given ID.");
            }

            entity.Active();

            _repositorie.SaveChanges();
        }

        public async Task Deactive(Guid id)
        {
            var entity = await _repositorie.FindByIdAsync(id);

            if (entity == null)
            {
                throw new NotFoundException("not found for the given ID.");
            }
            entity.Deactive();
            _repositorie.SaveChanges();

        }

        public async Task Delete(Guid id)
        {
            var entity = await _repositorie.FindByIdAsync(id);

            if (entity == null)
            {
                throw new NotFoundException("not found for the given ID.");
            }

            _repositorie.Delete(entity);

        }
    }
}
