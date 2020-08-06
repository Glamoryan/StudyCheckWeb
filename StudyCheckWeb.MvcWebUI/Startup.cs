using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudyCheck.Utilities.CustomIdentityError;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Business.Concrete;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUyeService, UyeManager>();
            services.AddSingleton<IUyeDal, EfUyeDal>();
            services.AddSingleton<IUyedetayService, UyedetayManager>();
            services.AddSingleton<IUyeDetayDal, EfUyeDetayDal>();
            services.AddSingleton<ISinavService, SinavManager>();
            services.AddSingleton<ISinavDal, EfSinavDal>();
            services.AddSingleton<ITemaService, TemaManager>();
            services.AddSingleton<ITemaDal, EfTemaDal>();
            services.AddSingleton<IDersService, DersManager>();
            services.AddSingleton<IDersDal, EfDersDal>();
            services.AddSingleton<IRolService, RolManager>();
            services.AddSingleton<IRolDal, EfRolDal>();
            services.AddSingleton<IYetkiService, YetkiManager>();
            services.AddSingleton<IYetkiDal, EfYetkiDal>();
            services.AddSingleton<ICalismaService, CalismaManager>();
            services.AddSingleton<ICalismaDal, EfCalismaDal>();

            services.AddSession();
            services.AddControllersWithViews();                

            services.AddDbContext<UserContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("AppData"));                
            },ServiceLifetime.Transient);

            services.AddIdentity<User, IdentityRole>(opt=> {
                opt.User.RequireUniqueEmail = true;                
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;                
            })
                .AddErrorDescriber<TurkceIdentityErrorDescriber>()
                .AddEntityFrameworkStores<UserContext>()
                .AddDefaultTokenProviders();            

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/sign/login";
                options.AccessDeniedPath = "/sign/accessDenied";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name:"AdminPaneli",
                    areaName:"Administrator",
                    pattern:"panel/{controller=Dashboard}/{action=Index}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(
                    name: "StudyPaneli",
                    areaName: "Study",
                    pattern: "study/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(
                    name:"SiteyeGiriþ",
                    areaName:"Sign",
                    pattern:"sign/{controller=Login}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );               
            });
        }
    }
}
