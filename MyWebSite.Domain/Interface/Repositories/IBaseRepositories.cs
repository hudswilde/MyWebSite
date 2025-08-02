namespace MyWebSite.Domain.Interface.Repositories
{
    public interface IBaseRepositories<T> where T : class
    {

        Task<T?> FindByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> SaveChanges();
    }
}
