using Microsoft.EntityFrameworkCore;

namespace Services.FoodStore.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
