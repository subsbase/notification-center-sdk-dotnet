using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class Notification
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("topicId")]
    public string TopicId { get; set; }
    
    [JsonPropertyName("subject")]
    public string Subject { get; set; }
    
    [JsonPropertyName("actionUrl")]
    public string ActionUrl { get; set; }
    
    [JsonPropertyName("read")]
    public bool Read { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}