using System;
using Newtonsoft.Json;

namespace DSMRReader.Net.Models;

public class EnergySupplierPrice
{
    public int Id { get; set; }

    public DateTime Start { get; set; }

    /// <summary>
    /// Set to a far future date when there is not contract end.
    /// </summary>
    public DateTime End { get; set; }

    /// <summary>
    /// For your own reference, i.e. the name of your supplier
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    [JsonProperty("electricity_delivered_1_price")]
    public string? ElectricityDelivered1Price { get; set; }

    /// <summary>
    /// Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    [JsonProperty("electricity_delivered_2_price")]
    public string? ElectricityDelivered2Price { get; set; }

    /// <summary>
    /// Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    public string? GasPrice { get; set; }

    /// <summary>
    /// Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    [JsonProperty("electricity_returned_1_price")]
    public string? ElectricityReturned1Price { get; set; }

    /// <summary>
    /// Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    [JsonProperty("electricity_returned_2_price")]
    public string? ElectricityReturned2Price { get; set; }

    /// <summary>
    /// Both positive and negative prices allowed. Set to zero when: Unused / Defined in other contract / Not applicable to your situation
    /// </summary>
    public string? FixedDailyCost { get; set; }
}