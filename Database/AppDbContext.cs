using Microsoft.EntityFrameworkCore;
using Netchat.Models;
using Microsoft.EntityFrameworkCore;

namespace Netchat.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

            public DbSet<Chat> Chats {get; set;}
            Public DbSet
        }
    }
}