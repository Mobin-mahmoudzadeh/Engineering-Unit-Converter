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

    public double ConvertKelvinToCelsius(double kelvin)
    {
        if (kelvin < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(kelvin), "Temperature cannot be below absolute zero (0 K).");
        }
        return kelvin - 273.15;
    }
}