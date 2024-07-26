

using System.Text.Json.Serialization;

public class Location
{
    [JsonPropertyName("city")] public string City { get; set; }
    [JsonPropertyName("state")] public string State { get; set; }
    [JsonPropertyName("country")] public string Country { get; set; }
}