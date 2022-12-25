using System;
using System.ComponentModel.DataAnnotations;
using DSMRReader.Net.Factory;

namespace DSMRReader.Net.DependencyInjection.Options;

public class DSMRReaderClientOptions
{
    [Required]
    public Uri BaseUrl { get; set; } = DSMRReaderApiFactory.BaseUrl;

    [Required]
    public string Token { get; set; } = null!;
}