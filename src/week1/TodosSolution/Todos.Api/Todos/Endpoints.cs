using Marten;
namespace Todos.Api.Todos;

public static class Endpoints
{
    // An "extension method"
    // this 
    public static IEndpointRouteBuilder MapTodos(this IEndpointRouteBuilder builder)
    {
        //GET /todos
        builder.MapGet("/todos", async (IDocumentSession session) => {
     
            var response = await session.Query<TodoListItem>().ToListAsync();

            return Results.Ok(response);

        });

        //POST /todos
        builder.MapPost("/todos", (TodoListCreateItem request) =>
        {

            var response = new TodoListItem
            {
                Id = Guid.NewGuid(),
                Description = request.Description,
                Completed = false,
                CreatedOn = DateTimeOffset.UtcNow
            };
            return Results.Ok(response);
        });
        return builder;
    }

}

public record TodoListItem
{
    public Guid Id { get; init; }
    public string Description { get; set; } = string.Empty;
    public bool Completed { get; set; }
    public DateTimeOffset CreatedOn { get; init; }
    public DateTimeOffset? CompletedOn { get; set; }
}


public record TodoListCreateItem
{
    public string Description { get; set; } = string.Empty;
}