using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class Subject
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("realm")]
    public string realmId { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}