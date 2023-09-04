using ApiProducto.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiProducto.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {
            
        }

        public DbSet <Producto> Productos { get; set; }

        
    }
}