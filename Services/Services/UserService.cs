using Data.Entities;
using Data.Repository;
namespace Service
{
    public class UserService
    {
        private readonly PrincipalRepository _repository;

        public UserService(PrincipalRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetAllUsers()
        {
            return _repository.GetUsers();
        }

        public void RegisterUser(User user)
        {
            _repository.AddUser(user);
        }

    }
}
