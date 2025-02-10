using Todos.Api.Todos;
using Marten;

namespace Todos.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        var connectionString = builder.Configuration.GetConnectionString("todos") ??
        throw new Exception("CAn't start the api without a connection string");
        builder.Services.AddMarten(builder =>
        {
            builder.Connection(connectionString);
        });

        app.UseAuthorization();

        app.MapTodos();

        app.Run();
    }
}
