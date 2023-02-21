using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


// Creating a simple sample demonstrating a single idea  for ISupportsConfigureWebHost 

namespace Project_WebHost
{

    // configuring the web host with custom middleware with ISupportsConfigureWebHost.

    public class Startup
    {
        public void ConfigureServices (IServiceCollection services )
        {

        }

        public void Configure (IApplicationBuilder app)
        {
            app.UseMiddleware<MyMiddleware>();
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello, World!");
            });
        }
    }

}
