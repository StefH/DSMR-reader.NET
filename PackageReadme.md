## Info
A C# client (using [RestEase](https://github.com/canton7/RestEase)) for [DSMRReader](https://github.com/dsmrreader/dsmr-reader): DSMR-protocol reader, telegram data storage and energy consumption visualizer.

## Example
``` c#
var factory = new DSMRReaderApiFactory();

var api = factory.GetApi("{token}");

var electricity = await api.ElectricityConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(electricity, Formatting.Indented));
```