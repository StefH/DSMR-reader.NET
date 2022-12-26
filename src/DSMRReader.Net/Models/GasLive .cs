using System;

namespace DSMRReader.Net.Models;

public class GasLive
{
    public DateTime Timestamp { get; set; }

    public string CurrentlyDelivered { get; set; }

    public string CostPerInterval { get; set; }
}