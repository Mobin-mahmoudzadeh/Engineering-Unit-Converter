namespace program;

public class TemperatureConverter
{
    public double ConvertCelsiusToFahrenheit(double temperature)
    {
        if (temperature < -273.15)
        {
            throw new ArgumentOutOfRangeException(nameof(temperature), "Temperature cannot be below absolute zero (-273.15°C).");
        }

        return (temperature * 9 / 5) + 32;
    }

    public double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        if (fahrenheit < -459.67)
        {
            throw new ArgumentOutOfRangeException(nameof(fahrenheit), "Temperature cannot be below absolute zero (-459.67°F)");
        }
        return (fahrenheit - 32) * 5 / 9;
    }
}