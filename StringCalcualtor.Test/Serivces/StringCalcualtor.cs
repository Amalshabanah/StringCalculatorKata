namespace StringCalcualtor.Serivces;
public class StringCalcualtor
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;
        if (!numbers.Contains(","))
            return Int32.Parse(numbers);
        else
        {
            int sum = 0;
            string[] nums;
            nums = numbers.Split(new char[] {',', '\n'});
            foreach (var num in nums)
            {
                sum += Int32.Parse(num);
            }

            return sum;
        }
    }
}