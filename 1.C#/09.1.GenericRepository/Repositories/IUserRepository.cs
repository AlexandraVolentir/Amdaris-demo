using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public interface IUserRepository: IBaseRepository<User>
    {
        public IEnumerable<User> GetAdults();
    }
}
