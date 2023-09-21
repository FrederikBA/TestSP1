using System.Text;

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

    public string ToRoman(int arabic)
    {
        if (arabic <= 0 || arabic >= 4000)
            throw new ArgumentOutOfRangeException("Input must be between 1 and 3999");

        // Define arrays of Roman numeral symbols and their corresponding values.
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        // Build the Roman numeral string.
        var result = new StringBuilder();
        var i = 0;

        while (arabic > 0)
        {
            if (arabic >= values[i])
            {
                result.Append(symbols[i]);
                arabic -= values[i];
            }
            else
            {
                i++;
            }
        }

        return result.ToString();
    }
}