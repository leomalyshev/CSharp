using SocketChat.Common.Entities;

namespace SocketChat.DAL.Repositories
{
    public static class UserRepository
    {
        private static List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }

        public static async Task<List<User>> GetAllAsync()
        {
            return await Task.Run(() => users);
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static async Task AddUserAsync(User user)
        {
            await Task.Run(() => users.Add(user));
        }
    }
}
