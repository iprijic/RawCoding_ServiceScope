using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ServiceScope.Services;

namespace ServiceScope
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITransientService, TransientService>();
            services.AddScoped<IScopedService, ScopedService>();
            services.AddSingleton<ISingletonService, SingletonService>();

            services.AddTransient<ITransientService1, TransientService1>();
            services.AddScoped<IScopedService1, ScopedService1>();
            services.AddSingleton<ISingletonService1, SingletonService1>();

            services.AddMvc((option) => { option.EnableEndpointRouting = false; });
        }

        public void Configure(IApplicationBuilder app, /*IHostingEnvironment*/ IWebHostEnvironment env)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}
