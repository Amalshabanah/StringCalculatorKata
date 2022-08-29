namespace StringCalcualtor.Serivces;
public class StringCalcualtor : IStringCalculator
{
    public int Add(string numbers)
    { 
        var sum = 0;
        var nums = numbers.Split(',');
        
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        if (!numbers.Contains(","))
            return Int32.Parse(numbers);
       
        foreach (var num in nums)
        {
            sum += Int32.Parse(num);
        }

        return sum;
    }
}