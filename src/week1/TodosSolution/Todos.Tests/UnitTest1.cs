using Todos.Api.Utils;

namespace Todos.Tests;


public class UnitTest1
{
    [Fact]
    public void CanFormatName()
    {
        //Given
        string firstName = "John", lastName = "Doe", fullName;
        var formatter = new Formatters();

        //When
        fullName = formatter.FormatName(lastName, firstName);

        //Then
        Assert.Equal("Doe, John", fullName);
    }

    [Theory]
    [InlineData("Luke", "Skywalker", "Skywalker, Luke")]
    public void CanFormatNameWithDifferentNames(string firstName, string lastName, string expected)
    {
        //Given
        var formatter = new Formatters();
        //When
        var fullName = formatter.FormatName(lastName, firstName);
        //Then
        Assert.Equal(expected, fullName);
    }
}
