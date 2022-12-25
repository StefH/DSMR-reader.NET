# DSMR-reader.NET
A C# .NET client (using [RestEase](https://github.com/canton7/RestEase)) for [DSMR-reader](https://github.com/dsmrreader/dsmr-reader): DSMR-protocol reader, telegram data storage and energy consumption visualizer.

## Install
| | |
| - | - |
| [![NuGet Badge](https://buildstats.info/nuget/DSMRReader.Net)](https://www.nuget.org/packages/DSMRReader.Net) | Main project
| [![NuGet Badge](https://buildstats.info/nuget/DSMRReader.Net.DependencyInjection)](https://www.nuget.org/packages/DSMRReader.Net.DependencyInjection) | Support for Microsoft DependencyInjection

## Example (using Factory)
``` c#
var factory = new DSMRReaderApiFactory();

var api = factory.GetApi(new Uri("http://lcoalhost:7777"), "__token__");

var e = await api.ElectricityConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(e, Formatting.Indented));
```

## Example (using DependencyInjection)
``` c#
// ---
    services.AddDSMRReaderClient("{token}");
// ---


var client = // injected

// Now call the api
```

### :books: References
- https://github.com/dsmrreader/dsmr-reader
- https://dsmr.home.decramy.net/docs/api/redoc

### :clap: Thanks
- https://github.com/RobThree/DSMR.Net