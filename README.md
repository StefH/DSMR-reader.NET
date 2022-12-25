# DSMR-reader.NET
A C# .NET client (using [RestEase](https://github.com/canton7/RestEase)) for [DSMR-reader](https://github.com/dsmrreader/dsmr-reader)

## Install
| | |
| - | - |
| [![NuGet Badge](https://buildstats.info/nuget/DSMRReader.Net)](https://www.nuget.org/packages/DSMRReader.Net) | Main project
| [![NuGet Badge](https://buildstats.info/nuget/DSMRReader.Net.DependencyInjection)](https://www.nuget.org/packages/DSMRReader.Net.DependencyInjection) | Support for Microsoft DependencyInjection

## Example (using Factory)
``` c#
var factory = new DSMRReaderApiFactory();

var DSMRReaderApi = factory.GetApi("{token}");

var request = new Request
{
    Version = "a9758cbfbd5f3c2094457d996681af52552901775aa2d6dd0b17fd15df959bef",
    Input = new Input
    {
        Prompt = "a gentleman cat with blue eyes wearing a tophat in a 19th century portrait"
    }
};

var response = await DSMRReaderApi.CreatePredictionAndWaitOnResultAsync(request).ConfigureAwait(false);
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