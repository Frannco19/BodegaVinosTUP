using BodegaDeVinosProyect.Entities;

namespace BodegaDeVinosProyect.Services
{
    public class UserService
    {
        private readonly PrincipalRepository _repository;

        // Inyección de dependencias a través del constructor
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
