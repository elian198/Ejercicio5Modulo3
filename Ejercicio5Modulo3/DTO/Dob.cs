

using System.Text.Json.Serialization;

public class Dob
{

    [JsonPropertyName("age")]
    public int Age { get; set; }

}