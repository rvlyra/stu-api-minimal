
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data
{
    public class AppDbContext : DbContext
    {
       
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}

