using BackendCoffeeNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendCoffeeNet.Data
{  
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {
        }

        
        // Colocar todos los modelos creados

        public DbSet<Usuarios> Usuarios {get; set;}

        public DbSet<Proveedores> Proveedores {get; set;}

        public DbSet<Categoria_Producto> CategoriaProductos {get; set;}

    } 
    
}