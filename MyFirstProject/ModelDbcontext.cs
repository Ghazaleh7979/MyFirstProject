using Microsoft.EntityFrameworkCore;

namespace MyFirstProject
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options)
            : base(options)
        {
        }

        public DbSet<Model> Products => Set<Model>();
    }
}