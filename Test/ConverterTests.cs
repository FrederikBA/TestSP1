using Core;

namespace Test;

public class ConverterTests
{
    [Fact]
    public void CelsiusToFahrenheitTest()
    {
        var converter = new ConverterService();
        var result = converter.CelsiusToFahrenheit(30);

        Assert.Equal(86, result);
    }
    
    [Fact]
    public void FahrenheitToCelsiusTest()
    {
        var converter = new ConverterService();
        var result = converter.FahrenheitToCelsius(100);

        Assert.Equal(37, result);
    }
}