
using System.Runtime.InteropServices;

public class Calculator
{
    public int Add(string number)
    {
        if (string.IsNullOrEmpty(number))
        {
            return 0;
        }

        if (number.Contains(","))
        {
            var splitNumbers = number.Split(',');
            var sum = 0;
            foreach (var num in splitNumbers)
            {
                
                sum += int.Parse(num);
            }
            return sum;
        }
        var intNumber = Convert.ToInt32(number);
        

        return intNumber;
    }
}
