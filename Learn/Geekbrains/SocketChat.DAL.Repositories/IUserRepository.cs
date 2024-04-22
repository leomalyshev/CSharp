using SocketChat.Common.Entities;

namespace SocketChat.DAL.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task AddUsersAsync(User user);
    }
}