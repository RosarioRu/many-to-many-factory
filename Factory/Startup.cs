using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Factory
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services.AddEntityFrameworkMySql() //added form of Entity that understands MySQL and configured that service to use a particula database context with the AddDbContext() which is a representation of our database.
        .AddDbContext<FactoryContext>(options => options
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();

      app.UseRouting();

      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Testing! Hello, Hello!");
      });
    }

  }
}