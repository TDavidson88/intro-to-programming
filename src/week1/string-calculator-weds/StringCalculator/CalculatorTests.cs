

using System;

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
    [InlineData("0")]
    [InlineData("1")]
    [InlineData("2")]
    [InlineData("3")]
    [InlineData("4")]
    public void StringConvertsToInteger(string number)
    {
        var calculator = new Calculator();
        var result = calculator.Add(number);
        Assert.Equal(int.Parse(number), result);
    }

    [Theory]
    [InlineData("1,2")]
    [InlineData("2,3")]
    [InlineData("3,4")]
    [InlineData("4,5")]
    [InlineData("5,6")]

    public void TwoNumbersReturnSum(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        var splitNumbers = numbers.Split(',');
        var num1 = int.Parse(splitNumbers[0]);
        var num2 = int.Parse(splitNumbers[1]);

        Assert.Equal(num1 + num2, result);
    }

    [Theory]
    [InlineData("1,2,3")]
    [InlineData("2,3,4,5")]
    [InlineData("3,4,5,6,7")]
    [InlineData("4,5,6,7,8,9")]
    public void MultipleNumbersReturnSum(string numbers)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        var splitNumbers = numbers.Split(',');
        var sum = 0;
        foreach (var num in splitNumbers)
        {
            sum += int.Parse(num);
        }
        Assert.Equal(sum, result);
    }
}
