using System;
using System.Threading.Tasks;
using Refit;

namespace Client
{
    public interface IGitHubApi
    {
        [Get("/users/{user}")]
        Task<User> GetUser(string user);
    }
}
