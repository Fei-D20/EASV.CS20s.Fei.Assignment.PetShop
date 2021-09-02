using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.Service;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Converter;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.IConverter;
using EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EASV.CS20s.Fei.Assignment.PetShop.WebApi
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo { Title = "Fei's Web Pet Shop", Version = "v1" });
            });

            services.AddScoped<IPetRepository,PetRepository>();
            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IPetConverter, PetConverter>();
            
            services.AddScoped<IPetTypeService, PetTypeService>();
            services.AddScoped<IPetTypeConverter, PetTypeConverter>();
            services.AddScoped<IPetTypeRepository, PetTypeRepository>();
            
            services.AddScoped<IOwnerService, OwnerService>();
            services.AddScoped<IOwnerConverter, OwnerConverter>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "EASV.CS20s.Fei.Assignment.PetShop.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}