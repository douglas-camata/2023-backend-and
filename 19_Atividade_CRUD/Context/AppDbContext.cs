using Microsoft.EntityFrameworkCore;
using CRUD_MVC.Models;

namespace CRUD_MVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos {get; set;} 
        public DbSet<Jogo> Jogos {get; set;} 
    }
}
