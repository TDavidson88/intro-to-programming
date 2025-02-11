namespace Todos.Api.Utils;

public class Formatters
{
    // Method that takes two strings and returns a string
    public string FormatName(string lastName, string firstName)
    {
        // Return the formatted string
        return $"{lastName}, {firstName}";
    }
}
