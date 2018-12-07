using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnD5e.API.Data.Context;
using DnD5e.API.Data.Repositories;
using DnD5e.API.Domain.Interfaces.Repositories;
using DnD5e.API.Domain.Interfaces.Services;
using DnD5e.API.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DnD5e.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //repositories
            services.AddScoped<ISpellRepository,SpellRepository>();

            //services
            services.AddScoped<ISpellService, SpellService>();

            services.AddDbContext<APIContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GearHost")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
