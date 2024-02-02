using Admin.Data;
using Admin.Service;
using Admin.Service.IService;
using AutoMapper;
using Business.Repository;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Admin
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
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IHotelRoomRepository, HotelRoomRepository>();
            services.AddScoped<IAmenityRepository, AmenityRepository>();
            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddScoped<IHotelImagesRepository, HotelImagesRepository>();
            services.AddScoped<IRoomOrderDetailsRepository, RoomOrderDetailsRepository>();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IAcceptanceCriteriaRepository, AcceptanceCriteriaRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanySoftware, CompanySoftwareRepository>();
            services.AddScoped<ICriteriaBasketRepository, CriteriaBasketRepository>();
            services.AddScoped<IDefectTypeRepository, DefectTypeRepository>();
            services.AddScoped<IFactoryDetailsRepository, FactoryDetailsRepository>();
            services.AddScoped<IImageProcessRepository, ImageProcessRepository>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
            services.AddScoped<IProjectDetailsRepository, ProjectDetailsRepository>();
            services.AddScoped<ITextInImageRepository, TextInImageRepository>();

            services.AddRazorPages();
            services.AddHttpContextAccessor();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
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
            app.UseAuthentication();
            app.UseAuthorization();
            dbInitializer.Initalize();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
