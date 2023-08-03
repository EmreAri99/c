using Microsoft.EntityFrameworkCore;
using WebApplication7.MODELS;

namespace WebApplication7
{
    public class startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(""));



        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }


          
        


    }
}
