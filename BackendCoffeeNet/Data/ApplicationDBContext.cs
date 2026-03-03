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

        public DbSet<Productos> Productos {get; set;}

        public DbSet<Pedidos> Pedidos {get; set;}

        public DbSet<DetallePedidos> DetallePedidos {get; set;}

        public DbSet<Insumos> Insumos {get; set;}

        public DbSet<Movimientos_Insumos> Movimientos_Insumos {get; set;}

        public DbSet<Recetas> Recetas {get; set;}

    } 
    
}