using SocketChat.Common.Entities;
using SocketChat.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketChat.BLL.Logic
{
    public class UserLogic : IUserLogic
    {
        public void Add(User user)
        {
            UserRepository.AddUser(user);
        }

        public async Task AddAsync(User user)
        {
            await UserRepository.AddUserAsync(user);
        }

        public List<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await UserRepository.GetAllAsync();
        }
    }
}
