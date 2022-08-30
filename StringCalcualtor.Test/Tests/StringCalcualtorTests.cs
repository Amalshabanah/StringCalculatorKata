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
    public void ShouldReturnZero(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1", 1)]
    public void ShouldReturnOneNumber(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1, 2", 3)]
    [InlineData("1,4", 5)]
    public void ShouldReturnSum(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("", 0)]
    [InlineData("2", 2)]
    [InlineData("1, 2\n 3", 6)]
    [InlineData("1,4", 5)]
    [InlineData("1\n2\n4", 7)]
    public void ShouldReturnSumSplitByCommaAndNewLine(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("1, 2, 4, 7, 8", 22)]
    [InlineData("1,19,50", 70)]
    public void ShouldReturnSumUnknownAmountOfNumbers(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2",3)]
    [InlineData("//s\n4s6", 10)]
    [InlineData("//!\n1!5!8", 14)]
    public void ShouldReturnSumDifferntDelimiters(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);   
    }
}