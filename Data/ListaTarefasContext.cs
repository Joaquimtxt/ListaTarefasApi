using ListaTarefasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefasApi.Data
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext(DbContextOptions<ListaTarefasContext> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TiposTarefa { get; set; }

    }
}
