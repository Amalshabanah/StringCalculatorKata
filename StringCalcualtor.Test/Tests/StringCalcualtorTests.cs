using StringCalcualtor.Serivces;
using Xunit;

namespace StringCalcualtor.Serivces;
public class StringCalcualtorTests
{
    private readonly IStringCalculator _stringCalculator;
    
    public StringCalcualtorTests()
    {
        _stringCalculator = new StringCalcualtor();
    }
    
    [Theory]
    [InlineData("", 0)]
    public void ShouldReturnZero(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1", 1)]
    public void ShouldReturnOneNumber(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1, 2", 3)]
    [InlineData("1,4", 5)]
    public void ShouldReturnSum(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("", 0)]
    [InlineData("2", 2)]
    [InlineData("1, 2\n 3", 6)]
    [InlineData("1,4", 5)]
    [InlineData("1\n2\n4", 7)]
    public void ShouldReturnSumSplitByCommaAndNewLine(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1, 2, 4, 7, 8", 22)]
    [InlineData("1,19,50", 70)]
    public void ShouldReturnSumUnknownAmountOfNumbers(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2",3)]
    [InlineData("//s\n4s6", 10)]
    [InlineData("//!\n1!5!8", 14)]
    public void ShouldReturnSumDifferntDelimiters(string numbers, int expected)
    {
        var result = _stringCalculator.Add(numbers);
        Assert.Equal(expected, result);   
    }
    [Theory]
    [InlineData("1,4,-1")]
    [InlineData("-1, -3")]
    public void ShouldThrowExpetionNegativeNumber(string numbers)
    {
        var exception = Assert.Throws<Exception>(() => _stringCalculator.Add(numbers));
        
        Assert.Contains(($"negatives are not allowed!"), exception.Message);
    }
}