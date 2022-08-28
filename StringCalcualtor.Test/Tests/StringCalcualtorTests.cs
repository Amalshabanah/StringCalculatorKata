global using Xunit;

namespace StringCalcualtor.Serivces;
public class StringCalcualtorTests
{
    private readonly StringCalcualtor _stringCalculator;
    
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
    [InlineData("//;\n1;2",3)]
    public void ShouldReturnSumDifferntDelimiters(string number, int expected)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);   
    }
}