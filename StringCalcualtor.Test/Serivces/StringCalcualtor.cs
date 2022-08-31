namespace StringCalcualtor.Serivces;
public class StringCalcualtor : IStringCalculator
{
    public int Add(string numbers)
    { 
        var sum = 0;
        string[] nums;

        if (numbers.StartsWith("//"))
        {
           var numberRemovedSlash = numbers.Replace("//", ""); 
           var delimiter = numberRemovedSlash[0];
           var numberRemovedDelimiterAndNewLine=  numberRemovedSlash.Remove(0, 2); 
           nums = numberRemovedDelimiterAndNewLine.Split(new char[] {'\n', delimiter});
           
            foreach (var num in nums)
            {
                sum += Int32.Parse(num);
            }

            return sum;
        }
        
        nums = numbers.Split(new char[] {',', '\n'});
        
        if (string.IsNullOrEmpty(numbers))
            return 0;
        
        if (!numbers.Contains(",") && !numbers.Contains("\n"))
            return Int32.Parse(numbers);
       
        foreach (var num in nums)
        {
            if (Int32.Parse(num) < 0)
            {
                throw new Exception($"negatives are not allowed! {num}");
            }
            
            sum += Int32.Parse(num);
        }

        return sum;
    }
}