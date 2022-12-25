## Info
A C# client (using [RestEase](https://github.com/canton7/RestEase)) for [DSMRReader](https://github.com/dsmrreader/dsmr-reader): DSMR-protocol reader, telegram data storage and energy consumption visualizer.

## Example
``` c#
var services = new ServiceCollection();

services.AddDSMRReaderClient(token);

var provider = services.BuildServiceProvider();

var api = provider.GetRequiredService<IDSMRReaderApi>();

var e = await api.ElectricityConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(e, Formatting.Indented));
```