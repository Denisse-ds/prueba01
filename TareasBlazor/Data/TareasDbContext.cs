using Microsoft.EntityFrameworkCore;
using TareasBlazor.Models;

namespace TareasBlazor.Data
{
    public class TareasDbContext : DbContext
    {
        public TareasDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; } //MODIFICADO: Agregamos <Tarea> para especificar el tipo de entidad
    }
}