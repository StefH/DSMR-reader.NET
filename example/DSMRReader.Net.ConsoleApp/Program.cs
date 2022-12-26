using DSMRReader.Net.Factory;
using Newtonsoft.Json;

var factory = new DSMRReaderApiFactory();

var api = factory.GetApi(new Uri("http://192.168.50.180:7777"), "BW1NY53R71O0BMHXVT4B7R0LD7UBO9K02D4LCCG4D92V279QG1DPT8M9NR7F11UP");

// Application
var applicationVersion = await api.GetApplicationVersionAsync();
WriteLine(applicationVersion);

var applicationMonitoring = await api.GetApplicationMonitoringAsync();
WriteLine(applicationMonitoring);


// DataLogger
var readings = await api.GetDataLoggerReadingsAsync(timestampGte: "2022-01-15 00:00:00");
WriteLine(readings);

var meterStatistics = await api.GetMeterStatisticsAsync();
WriteLine(meterStatistics);


// Consumption
var prices = await api.GetEnergySupplierPricesAsync();
WriteLine(prices);

var electricityConsumptionLive = await api.GetElectricityConsumptionLiveAsync();
WriteLine(electricityConsumptionLive);

var electricityConsumptions = await api.GetElectricityConsumptionsAsync(readAtGte: "2022-12-24");
WriteLine(electricityConsumptions);

var getQuarterHourPeakElectricityConsumptionsAsync = await api.GetQuarterHourPeakElectricityConsumptionsAsync();
WriteLine(getQuarterHourPeakElectricityConsumptionsAsync);

var gasConsumptionLive = await api.GetGasConsumptionLiveAsync();
WriteLine(gasConsumptionLive);

var gasConsumptions = await api.GetGasConsumptionsAsync();
WriteLine(gasConsumptions);

// Statistics
var today = await api.GetTodaysConsumptionsAsync();
WriteLine(today);

var dayStatistics = await api.GetDayStatisticsAsync();
WriteLine(dayStatistics);

var hourStatistics = await api.GetHourStatisticsAsync();
WriteLine(hourStatistics);

static void WriteLine(object value)
{
    Console.WriteLine(JsonConvert.SerializeObject(value, DSMRReaderApiFactory.JsonSerializerSettings));
}