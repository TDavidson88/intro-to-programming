

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
     
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("0", 0)]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    [InlineData("4", 4)]
    [InlineData("5", 5)]
    [InlineData("6", 6)]
    [InlineData("7", 7)]
    [InlineData("9", 9)]

    public void StringWithOneNumberReturnsNumber(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,3", 5)]
    [InlineData("3,4", 7)]
    [InlineData("4,5", 9)]
    [InlineData("5,6", 11)]
    [InlineData("6,7", 13)]
    [InlineData("7,8", 15)]

    public void StringWithTwoNumbersReturnsSum(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("2,3,4,5", 14)]
    [InlineData("3,4,5,6,7", 25)]
    [InlineData("4,5,6,7,8,9", 39)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]

    public void StringWithMultipleNumbersReturnsSum(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2\n3", 6)]
    [InlineData("2\n3,4,5", 14)]
    [InlineData("3,4\n5,6\n7", 25)]
    [InlineData("4,5\n6,7\n8,9", 39)]

    public void StringWithMultipleNumbersAndNewLinesReturnsSum(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//#\n1#2", 3)]
    [InlineData("//#\n2#3#4#5", 14)]
    [InlineData("//#\n3#4#5#6#7", 25)]
    [InlineData("//#\n4#5#6#7#8#9", 39)]
    public void StringWithMultipleNumbersAndCustomDelimiterReturnsSum(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    //Still need to implement this test 
    //[Theory]
    //[InlineData("1,-2")]
    //[InlineData("-1,2")]
    //[InlineData("-1,-2")]
    //[InlineData("1,-2,-3")]
    //[InlineData("-1,-2,-3")]

    //public void StringWithNegativeNumberThrowsException(string input)
    //{
    //    var calculator = new Calculator();
    //    Assert.Throws<Exception>(() => calculator.Add(input));
    //}
}
