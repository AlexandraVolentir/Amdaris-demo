using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void Remove(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
