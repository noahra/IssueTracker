using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Environment = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<IssueTrackerContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("IssueTrackerContext");

                if (Environment.IsDevelopment())
                {
                    options.UseSqlite(connectionString);
                }
                else
                {
                    options.UseSqlServer(connectionString);
                }
            });

            services.AddDbContext<UserContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("UserContext")));

            services.AddDbContext<AssignmentContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("AssignmentContext")));

            services.AddDbContext<ProjectContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("ProjectContext")));

            services.AddDbContext<CommentContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("CommentContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Issue}/{action=Index}/");
            });
        }
    }
}
