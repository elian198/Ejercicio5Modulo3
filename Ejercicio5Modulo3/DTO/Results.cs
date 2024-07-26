
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

public class Results
{
    [JsonPropertyName("gender")] public string gender { get; set; }
    [JsonPropertyName("name")] public Name Name { get; set; }
    //[JsonPropertyName("location")] public Location Location { get; set; }
    [JsonPropertyName("email")] public string Email { get; set; }
    [JsonPropertyName("login")] public Login Login { get; set; }
    [JsonPropertyName("dob")] public Dob Dob { get; set; }
    [JsonPropertyName("location")] public Location Location { get; set; }


}