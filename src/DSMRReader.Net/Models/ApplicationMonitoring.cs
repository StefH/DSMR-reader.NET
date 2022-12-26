using System;

namespace DSMRReader.Net.Models;

public class ApplicationMonitoring
{
    public int Problems { get; set; }

    public object[] Details { get; set; } = Array.Empty<object>();
}