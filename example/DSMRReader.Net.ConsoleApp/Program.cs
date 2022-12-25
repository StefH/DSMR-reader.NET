using DSMRReader.Net.Factory;
using Newtonsoft.Json;

var factory = new DSMRReaderApiFactory();

var api = factory.GetApi(new Uri("http://192.168.50.180:7777"), "BW1NY53R71O0BMHXVT4B7R0LD7UBO9K02D4LCCG4D92V279QG1DPT8M9NR7F11UP");

var e = await api.ElectricityConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(e, Formatting.Indented));

var g = await api.GasConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(g, Formatting.Indented));
