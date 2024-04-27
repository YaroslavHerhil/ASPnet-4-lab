using ASPnet_4_lab.Abstract;
using ASPnet_4_lab.Repository.Abstract;
using ASPnet_4_lab.Repository.Repositories;
using ASPnet_4_lab.Service;

namespace ASPnet_4_lab
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookRepoService>();

            services.AddRazorPages();
        }

    }
}
