global using Xunit;

namespace StringCalcualtor.Serivces;
public class StringCalcualtorTests
{
    private readonly StringCalcualtor _stringCalculator;
    public StringCalcualtorTests()
    {
        _stringCalculator = new StringCalcualtor();
    }
    
    [Fact]
    [InlineData(0, "")]
    public void ShouldReturnZero()
    {
        var result = _stringCalculator.Add("");
        Assert.Equal(0, result);
    }
    
    [InlineData(1,"1")]
    public void ShouldReturnOneNumber()
    {
        var result = _stringCalculator.Add("1");
        Assert.Equal(1, result);
    }
    
    public void ShouldReturnSum()
    {
        var result = _stringCalculator.Add("1, 2");
        Assert.Equal(3, result);
    }
    [Fact]
    public void ShouldReturnSumSplitByCommaAndNewLine()
    {
        var result = _stringCalculator.Add("1, 2\n 3");
        Assert.Equal(6, result);
    }
}