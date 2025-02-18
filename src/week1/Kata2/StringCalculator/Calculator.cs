
using System.Linq;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Calculator
{

    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var delimiters = new[] { ',', '\n' };

        if (numbers.StartsWith("//"))
        {
            var delimiter = numbers[2];
            numbers = numbers.Substring(4);
            delimiters = new[] { delimiter };
        }

        var parts = numbers.Split(delimiters);
        var sum = 0;
        var negativeNumbers = new List<int>();

        foreach (var part in parts)
        {
            var number = int.Parse(part);
            if (number < 0)
            {
                negativeNumbers.Add(number);
            }
            if (number > 1000)
            {
                continue;
            }
            sum += number;
        }

        if (negativeNumbers.Any())
        {
            throw new ArgumentException("Negatives not allowed " + string.Join(", ", negativeNumbers));
        }

        return sum;
    }
}

