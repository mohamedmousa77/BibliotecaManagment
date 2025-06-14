using BibliotecaAPI.Repositories;
using BibliotecaManager.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BibliotecaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<DataStorageService>();
            builder.Services.AddScoped<IAuthorsRepositories, AuthorsRepositories>();


            builder.Services.AddScoped<IClientsRepositories, ClientsRepositories>();


            builder.Services.AddControllers();

            // Aggiungi Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(config =>
                {
                    config.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                    config.RoutePrefix = string.Empty; 
                });
            }

        // Configure the HTTP request pipeline.

        //app.UseHttpsRedirection();

        app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
