using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthDataLayer;
using AuthDataLayer.Repositories;
using AuthDataLayer.Utils;
using Check_InAdmin.ModelBuilders;
using EventsDataLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestionDataLayer;
using QuestionDataLayer.ModelBuilders;
using QuestionDataLayer.Repository;

namespace Check_InAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<UserContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString")));       
            services.AddDbContext<QuestionsContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("QuestionContext")));
            services.AddDbContext<EventContext>(options =>
         options.UseSqlServer(Configuration.GetConnectionString("EventContext")));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                          .AddCookie(options =>
                          {
                              options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Login");
                              options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Login");

                          });


            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IGroupsRepository, GroupsRepository>();
            services.AddScoped<ILoginUtil, LoginUtil>();
            services.AddScoped<IPasswordHash, PasswordHash>();
            services.AddScoped<IDataInViewModelBuilder, DataInViewModelBuilder>();
            services.AddScoped<IQuestinosRepository, QuestinosRepository>();
            services.AddScoped<IQuestionModelBuilder, QuestionModelBuilder>();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });

           
        }
    }
}
