using Microsoft.EntityFrameworkCore;
using SocketChat.Common.Entities;

namespace SocketChat.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChatContext _chatContext;
        //private static List<User> users = new List<User>();

        //public static List<User> GetAll()
        //{
        //    return users;
        //}

        //public static async Task<List<User>> GetAllAsync()
        //{
        //    return await Task.Run(() => users);
        //}

        //public static void AddUser(User user)
        //{
        //    users.Add(user);
        //}

        //public static async Task AddUserAsync(User user)
        //{
        //    await Task.Run(() => users.Add(user));
        //}

        public UserRepository(ChatContext chatContext)
        {
            _chatContext = chatContext;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _chatContext.Users.ToListAsync();
        }

        public async Task AddUsersAsync(User user)
        {
            await _chatContext.Users.AddAsync(user);
            await _chatContext.SaveChangesAsync();
        }
    }
}
