using System.Threading.Tasks;
using MyProjects_V2.Git.DatingApp.DatingApp.API.Models;

namespace MyProjects_V2.Git.DatingApp.DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login (string username, string password);
         Task<bool> UserExists (string username);
    }
}