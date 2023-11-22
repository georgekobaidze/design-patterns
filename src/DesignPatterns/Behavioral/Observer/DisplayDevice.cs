using System;

namespace DesignPatterns.Behavioral.Observer;

// Concrete observer
public class DisplayDevice : IDisplayDevice
{
    private string _name;

    public DisplayDevice(string name)
    {
        this._name = name;
    }

    public void Update(WeatherStation weatherStation)
    {
        Console.WriteLine($"{_name} updated - Temperature: {weatherStation.Temperature}, Humidity: {weatherStation.Humidity}");
    }
}
