using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class BaseRequest
{
    
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
    
}