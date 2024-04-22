using Microsoft.EntityFrameworkCore;
using SocketChat.Common.Entities;

namespace SocketChat.DAL.Repositories
{
    public class ChatContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
