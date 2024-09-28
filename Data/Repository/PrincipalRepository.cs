using Data.Entities;
using System;

namespace Data.Repository
{
    public class PrincipalRepository
    {
        private List<Wine> wines = new List<Wine>();

        private List<User> users = new List<User>();

        public List<Wine> GetWines() => wines;
        public void AddWine(Wine wine) => wines.Add(wine);

        public List<User> GetUsers() => users;
        public void AddUser(User user) => users.Add(user);
    }

}
