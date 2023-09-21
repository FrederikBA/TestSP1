namespace Core;

public class ConverterService
{
    public int FahrenheitToCelsius(int fahrenheit)
    {
        //Fahrenheit to Celsius Formula: (°F - 32) / 1.8 = °C
        return (int)Math.Round((fahrenheit - 32) / 1.8, 1);
    }
    public int CelsiusToFahrenheit(int celsius)
    {
        //Celsius to Fahrenheit Formula: (°C * 1.8) + 32 = °F
        return (int)Math.Round((celsius * 1.8) + 32, 1);
    }
}