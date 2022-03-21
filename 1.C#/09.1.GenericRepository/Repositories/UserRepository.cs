using GenericRepository.Entities;

namespace GenericRepository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public IEnumerable<User> GetAdults()
        {
            return _entities.Where(e => e.Age > 18).ToList();
        }
    }
}
