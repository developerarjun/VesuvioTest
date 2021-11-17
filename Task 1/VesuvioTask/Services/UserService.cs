using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesuvioTask.Helpers;

namespace VesuvioTask.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Test", LastName = "User", Username = "BatMan123", Password = "heLOgen92" }
        };

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == username && x.Password == password));

            if (user == null)
                return null;

            return user.WithoutPassword();
        }
    }
    
}
