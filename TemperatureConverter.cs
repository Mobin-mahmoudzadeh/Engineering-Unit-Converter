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
}