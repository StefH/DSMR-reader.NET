using System;

namespace DSMRReader.Net.Models;

public class ElectricityLive
{
    public DateTime Timestamp { get; set; }

    public int CurrentlyDelivered { get; set; }

    public int CurrentlyReturned { get; set; }

    public object? CostPerHour { get; set; }

    public string TariffName { get; set; } = null!;
}