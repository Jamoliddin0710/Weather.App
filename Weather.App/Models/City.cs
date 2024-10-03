namespace Weather.App.Models;

public class City
{
    public string CityName { get; set; }
    public DateTime DateAndTime { get; set; }
    public string UniqueCode { get; set; }
    public int TemperatureFahrenheit { get; set; }
}