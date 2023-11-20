using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer;

// Subject
public class WeatherStation
{
    private decimal _temperature;
    private decimal _humidity;
    private List<IDisplayDevice> _displayDevices = new List<IDisplayDevice>();
    
    public decimal Temperature
    {
        get { return _temperature; }
        set
        {
            if (_temperature != value)
            {
                _temperature = value;
                NotifyDisplayDevices();
            }
        }
    }
    
    public decimal Humidity
    {
        get { return _humidity; }
        set
        {
            if (_humidity != value)
            {
                _humidity = value;
                NotifyDisplayDevices();
            }
        }
    }
    
    public void AttachDisplayDevice(IDisplayDevice displayDevice)
    {
        _displayDevices.Add(displayDevice);
    }

    public void DetachDisplayDevice(IDisplayDevice displayDevice)
    {
        _displayDevices.Remove(displayDevice);
    }

    private void NotifyDisplayDevices()
    {
        foreach (var displayDevice in _displayDevices)
        {
            displayDevice.Update(this);
        }
    }
}
