using Microsoft.EntityFrameworkCore;

namespace LibroAPI.Models
{
    public class LibroContext:DbContext
    {
        public LibroContext(DbContextOptions<LibroContext> options) : base(options) { }
        public DbSet<Libro> Libros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libro>().HasData(
                new Libro
                {
                    Id = 1,
                    Titulo = "Cien años de soledad",
                    Autor = "Gabriel Garcia Marquez",
                    AnioPublicacion = "1967"
                },
                new Libro
                {
                    Id = 2,
                    Titulo = "Don Quijote de la mancha",
                    Autor = "Miguel de Cervantes",
                    AnioPublicacion = "1605"
                },
                new Libro
                {
                    Id = 3,
                    Titulo = "El amor en los tiempos de Colera",
                    Autor = "Gabriel Garcia Marquez",
                    AnioPublicacion = "1985"
                }
            );
        }
    }
}
