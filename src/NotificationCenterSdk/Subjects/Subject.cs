using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class Subject
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("topics")]
    public Dictionary<string, Topic> Topics = new();
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    
   
}