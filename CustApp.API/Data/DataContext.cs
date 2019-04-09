using Microsoft.EntityFrameworkCore;

namespace CustApp.API.Model
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}