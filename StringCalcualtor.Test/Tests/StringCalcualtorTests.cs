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
    [InlineData(0, "")]
    public void ShouldReturnZero(int expected, string number)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1,"1")]
    public void ShouldReturnOneNumber(int expected, string number)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(3,"1, 2")]
    [InlineData(5,"1,4")]
    public void ShouldReturnSum(int expected, string number)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(22,"1, 2, 4, 7, 8")]
    public void ShouldReturnSumUnknownAmountOfNumbers(int expected, string number)
    {
        var result = _stringCalculator.Add(number);
        Assert.Equal(expected, result);
    }
}