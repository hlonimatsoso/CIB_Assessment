using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CIB.PhoneBookBlazorApp.Data;
using CIB.Models;
using Microsoft.EntityFrameworkCore;
using CIB.PhoneBookData;
using CIB.Interfaces;
using CIB.PhoneBookBlazorApp.Data.Services;
using EmbeddedBlazorContent;
using System.Net.Http;

namespace CIB.PhoneBookBlazorApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<PhoneBookEntry>();
            services.AddTransient<PhoneBook>();
            services.AddDbContext<PhoneBookDBContext>(optionBuilder => optionBuilder.UseSqlServer($"{Configuration.GetSection("ConnectionStrings:Default").Value}"));
            services.AddTransient<IPhoneBookRepo, PhoneBookSqlRepo>();
            services.AddTransient<IPhoneBookService, PhoneBookService>();
            services.AddTransient<IPhoneBookEntryService, PhoneBookEntryService>();
            services.AddScoped<HttpClient>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IPhoneBookRepo repo)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            app.UseEmbeddedBlazorContent(typeof(MatBlazor.BaseMatComponent).Assembly);

            repo.RunMigration();

            //app.RunMigration();
        }
    }
}
