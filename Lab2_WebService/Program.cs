
using Lab2_WebService.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2_WebService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Añadir el contexto de la bases de datos 
            // builder.Services.AddDbContext<>(); 
            builder.Services.AddDbContext<FallEventsDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("conexionlab2")));

            // Configurar CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });


            // Configurar la aplicación para escuchar en todas las interfaces de red en el puerto 5003
            builder.WebHost.UseUrls("http://0.0.0.0:5003");



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            // Usar CORS
            app.UseCors("AllowAll");

            app.MapControllers();

            app.Run();
        }


    }
}
