namespace StringCalcualtor.Serivces;
public class StringCalculator : IStringCalculator
{ 
    public int Add(string numbers)
    { 
        var sum = 0;
        var nums = numbers.Split(new char[] {',', '\n'});
        
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        if (!numbers.Contains(",") && !numbers.Contains("\n"))
            return Int32.Parse(numbers);
       
        foreach (var num in nums)
        {
            sum += Int32.Parse(num);
        }

        return sum;
    }
}