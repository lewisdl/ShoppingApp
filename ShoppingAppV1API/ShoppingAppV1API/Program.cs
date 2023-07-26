using Microsoft.EntityFrameworkCore;
using ShoppingAppV1API.Models;
using ShoppingAppV1API.Services;

namespace ShoppingAppV1API
{
    public class Program
    {
        //Fixed Certain conventions (putting underscores infront private var)
        //LINQ queries used in CartService
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CartContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CartContext")));
            builder.Services.AddDbContext<ItemContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ItemContext")));
            
            builder.Services.AddScoped<CartService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}