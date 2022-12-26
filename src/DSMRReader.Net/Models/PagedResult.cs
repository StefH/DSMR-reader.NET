using System;

namespace DSMRReader.Net.Models;

public class PagedResult<T>
{
    public int Count { get; set; }

    // http://api.example.org/accounts/?offset=400&limit=100
    public string? Next { get; set; }

    // http://api.example.org/accounts/?offset=200&limit=100
    public string? Previous { get; set; }

    public T[] Results { get; set; } = Array.Empty<T>();
}