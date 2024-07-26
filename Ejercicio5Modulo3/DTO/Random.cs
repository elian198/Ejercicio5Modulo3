

using System.Text.Json.Serialization;

public class Random
{
    [JsonPropertyName("results")]  public List<Results> Results { get; set; }
}