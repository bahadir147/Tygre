using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Tygre.OM.Entities;
using Tygre.OM.Repositories.Absract;
using Tygre.OM.Repositories.Concrete.EntityFramework;
using Tygre.OM.Services.Abstract;
using Tygre.OM.Services.Concrete;

namespace Tygre.OM.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/login";
                    options.LogoutPath = "/Account/logout";
                });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            #region INJECTION

            services.AddTransient<IPersonelService, PersonelService>();
            services.AddTransient<IPersonelRepository, PersonelRepository>();

            services.AddTransient<IPersonelYetkiService, PersonelYetkiService>();
            services.AddTransient<IPersonelYetkiRepository, PersonelYetkiRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseStatusCodePagesWithRedirects("/error");


            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
