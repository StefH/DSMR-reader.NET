using Newtonsoft.Json;

namespace DSMRReader.Net.Models;

public class Today
{
    public string Day { get; set; } = null!;

    public float Electricity1 { get; set; }

    public float Electricity2 { get; set; }

    [JsonProperty("electricity1_returned")]
    public float Electricity1Returned { get; set; }

    [JsonProperty("electricity2_returned")]
    public float Electricity2Returned { get; set; }

    public float ElectricityMerged { get; set; }

    public float ElectricityReturnedMerged { get; set; }

    [JsonProperty("electricity1_cost")]
    public float Electricity1Cost { get; set; }

    [JsonProperty("electricity2_cost")]
    public float Electricity2Cost { get; set; }

    public float TotalCost { get; set; }

    public float Gas { get; set; }

    public float GasCost { get; set; }

    public float FixedCost { get; set; }

    [JsonProperty("energy_supplier_price_electricity_delivered_1")]
    public float EnergySupplierPriceElectricityDelivered1 { get; set; }

    [JsonProperty("energy_supplier_price_electricity_delivered_2")]
    public float EnergySupplierPriceElectricityDelivered2 { get; set; }

    [JsonProperty("energy_supplier_price_electricity_returned_1")]
    public float EnergySupplierPriceElectricityReturned1 { get; set; }

    [JsonProperty("energy_supplier_price_electricity_returned_2")]
    public float EnergySupplierPriceElectricityReturned2 { get; set; }

    public float EnergySupplierPriceGas { get; set; }

    public float EnergySupplierPriceFixedDailyCost { get; set; }
}