using Microsoft.EntityFrameworkCore;

namespace ProductoAPI.Models
{
    public class ProductoContext:DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptop",
                    Categoria = "Electronica",
                    Descripcion = "Una Laptop de alto rendimiento"
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Smartphone",
                    Categoria = "Electronica",
                    Descripcion = "Samsung Galaxy Note 20"
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Silla",
                    Categoria = "Muebles",
                    Descripcion = "Silla Gaming corsair"
                }
            );
        }
    }
}
