using Microsoft.EntityFrameworkCore;
using _18_CRUD_BD.Models;

namespace _18_CRUD_BD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //No meu DbSet carregará todos os jogos salvos no banco de dados
        public DbSet<Jogo> Jogos {get; set;}

    }
}