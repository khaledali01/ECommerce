
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ECommerceContext _context;

        public GenericRepository(ECommerceContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Insert(T obj)
        {
            await _context.Set<T>().AddAsync(obj);
            await Save();
        }

        public async Task<T> Find(T obj)
        {
            var result = await GetAll();
            return result.FirstOrDefault(n => n == obj);
        }

        public async Task Update(T obj)
        {
            _context.Set<T>().Update(obj);
            await Save();
        }


        public async Task Delete(T obj)
        {
            T result = await Find(obj);
            _context.Set<T>().Remove(result);
            await Save();
        }


        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }


    }
}