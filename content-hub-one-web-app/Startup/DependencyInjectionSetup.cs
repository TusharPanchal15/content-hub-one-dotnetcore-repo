
using Content_Hub_One_WEb_App.Services
namespace Content_Hub_One_WEb_App.Startup
{
    public static class DependencyInjecionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddControllersWithViews();
            services.AddHttpClient<SitecoreApiClient>();
            services.AddScoped<HomepageService>();
            services.AddControllersWithViews();
            return services;
        }

    }
}