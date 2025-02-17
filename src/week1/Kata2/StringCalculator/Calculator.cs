
using System.Linq;
using System.Numerics;

public class Calculator
{

    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }


        var delimiters = new[] { ',', '\n', '#' };

        if (numbers.StartsWith("//"))
        {
            var delimiter = numbers[2];
            numbers = numbers.Substring(4);
            delimiters = new[] { delimiter };


            var parts = numbers.Split(delimiters);
            var sum = 0;
            foreach (var num in parts)
            {
                    sum += int.Parse(num);
                    
            }
            return sum;
        }

        else
        {
            var parts = numbers.Split(delimiters);
            var sum = 0;
            foreach (var num in parts)
            {
                    sum += int.Parse(num);

            }
            return sum;

        }
    }
}
