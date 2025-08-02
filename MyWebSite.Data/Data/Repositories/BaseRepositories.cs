using Microsoft.EntityFrameworkCore;
using MyWebSite.Domain.Interface.Repositories;
using MyWebSite.Infrastructure.Data.Context;

namespace MyWebSite.Infrastructure.Data.Repositories
{
    public abstract class BaseRepositories<T>: IBaseRepositories<T> where T : class
    {
        protected readonly MyWebSiteContext _context;
        protected readonly DbSet<T> _dbSet;

       public BaseRepositories(MyWebSiteContext context) { 
            _context = context; 
            _dbSet = context.Set<T>();
       }

        public async Task<T?> FindByIdAsync(Guid id)
        {
            return await   _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
