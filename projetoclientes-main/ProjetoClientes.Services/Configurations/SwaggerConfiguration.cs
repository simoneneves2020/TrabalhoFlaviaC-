using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClientes.Services.Configurations
{
    /// <summary>
    /// Classe para configuração do Swagger. Esta configuração deverá
    /// ser inserida nos métodos da classe /Startup
    /// </summary>
    public class SwaggerConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API para controle de clientes (DDD e TDD)",
                    Description = "Projeto desenvolvido em NET CORE API com EntityFramework e SqlServer",
                    Contact = new OpenApiContact
                    {
                        Name = "Simone Neves",
                        Url = new Uri("http://www.simone.santana.neves@gmail.com.br"),
                        Email = "simone.neves@rj.senac.br"
                    }
                });
            });
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetoAPI02");
            });
        }
    }
}
