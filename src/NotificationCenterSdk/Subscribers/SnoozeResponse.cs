using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class SnoozeResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
    
}