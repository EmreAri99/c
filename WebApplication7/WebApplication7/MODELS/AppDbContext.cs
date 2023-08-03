using Microsoft.EntityFrameworkCore;

namespace WebApplication7.MODELS
{
    public class AppDbContext: DbContext
    {

        public  AppDbContext (DbContextOptions<AppDbContext> options) 
            :base()
        {

        }
         
        public DbSet<Category> categories { get; set; }
        public object Categories { get; internal set; }
        public DbSet<Todo> Todos { get; set; }       

    }
}
