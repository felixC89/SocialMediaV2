﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMedia.Core.Interfaces;
using SocialMedia.InfraStructure.Data;
using SocialMedia.InfraStructure.Repositories;

namespace SocialMedia.Api
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

            #region ############## Inyeccion de dependencias de cadena de conexion Base de datos al contexto SocialMedia ##############
            services.AddDbContext<SocialMediadbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SocialMediaCS")));
            #endregion

            #region ############## Inyeccion de dependencias ##############
            //Cada vez que se haga uso abstraccion (IPostRepository) se le va entregar una instacia de la implementacion (PostRepository o el repositorio que se tenga que usar)
            services.AddTransient<IPostRepository, PostRepository>();
            #endregion
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
