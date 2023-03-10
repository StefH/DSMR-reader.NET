using System;

namespace DSMRReader.Net.Models;

public class GasConsumption
{
    public int Id { get; set; }

    public DateTime ReadAt { get; set; }

    /// <summary>
    /// Last meter position read
    /// </summary>
    public string? Delivered { get; set; } = null!;

    /// <summary>
    /// Delivered value, based on the previous reading
    /// </summary>
    public string CurrentlyDelivered { get; set; } = null!;
}