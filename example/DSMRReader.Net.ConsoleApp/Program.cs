using DSMRReader.Net.Factory;
using Newtonsoft.Json;

var factory = new DSMRReaderApiFactory();

var api = factory.GetApi(new Uri("http://192.168.50.180:7777"), "BW1NY53R71O0BMHXVT4B7R0LD7UBO9K02D4LCCG4D92V279QG1DPT8M9NR7F11UP");

// Application
var applicationVersion = await api.GetApplicationVersionAsync();
Console.WriteLine(JsonConvert.SerializeObject(applicationVersion, Formatting.Indented));

var applicationMonitoring = await api.GetApplicationMonitoringAsync();
Console.WriteLine(JsonConvert.SerializeObject(applicationMonitoring, Formatting.Indented));


// DataLogger
var readings = await api.GetDataLoggerReadingsAsync(timestampGte: "2022-01-15 00:00:00");
Console.WriteLine(JsonConvert.SerializeObject(readings, Formatting.Indented));

var meterStatistics = await api.GetMeterStatisticsAsync();
Console.WriteLine(JsonConvert.SerializeObject(meterStatistics, Formatting.Indented));


// Consumption
var prices = await api.GetEnergySupplierPricesAsync();
Console.WriteLine(JsonConvert.SerializeObject(prices, Formatting.Indented));

var electricityConsumptionLive = await api.GetElectricityConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(electricityConsumptionLive, Formatting.Indented));

var electricityConsumptions = await api.GetElectricityConsumptionsAsync(readAtGte: "2022-12-24");
Console.WriteLine(JsonConvert.SerializeObject(electricityConsumptions, Formatting.Indented));

var getQuarterHourPeakElectricityConsumptionsAsync = await api.GetQuarterHourPeakElectricityConsumptionsAsync();
Console.WriteLine(JsonConvert.SerializeObject(getQuarterHourPeakElectricityConsumptionsAsync, Formatting.Indented));

var gasConsumptionLive = await api.GetGasConsumptionLiveAsync();
Console.WriteLine(JsonConvert.SerializeObject(gasConsumptionLive, Formatting.Indented));

var gasConsumptions = await api.GetGasConsumptionsAsync();
Console.WriteLine(JsonConvert.SerializeObject(gasConsumptions, Formatting.Indented));

// Statistics
var today = await api.GetTodaysConsumptionsAsync();
Console.WriteLine(JsonConvert.SerializeObject(today, Formatting.Indented));

var dayStatistics = await api.GetDayStatisticsAsync();
Console.WriteLine(JsonConvert.SerializeObject(dayStatistics, Formatting.Indented));

var hourStatistics = await api.GetHourStatisticsAsync();
Console.WriteLine(JsonConvert.SerializeObject(hourStatistics, Formatting.Indented));