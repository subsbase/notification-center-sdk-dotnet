using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class NotificationTemplate
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("message")]
    public string Message { get; set; }
}