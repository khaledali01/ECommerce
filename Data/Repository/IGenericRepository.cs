namespace ECommerce.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T obj);
        Task<T> Find(T obj);
        Task Update(T obj);
        Task Delete(T obj);
        Task Save();

    }
}