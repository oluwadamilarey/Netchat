using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Netchat.Models;
using Microsoft.EntityFrameworkCore;

namespace Netchat.Database
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Chat> Chats {get; set;}
        public DbSet<Message> Messages { get; set;}
        
    }
}