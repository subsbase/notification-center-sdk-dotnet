using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class Notification
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("topic")]
    public string TopicId { get; set; }
    
    [JsonPropertyName("content")]
    public string Content { get; set; }
    
    [JsonPropertyName("actionUrl")]
    public string ActionUrl { get; set; }
    
    [JsonPropertyName("read")]
    public bool Read { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}