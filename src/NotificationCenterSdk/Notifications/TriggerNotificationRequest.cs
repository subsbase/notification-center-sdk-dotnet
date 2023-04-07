using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Notifications;

public class TriggerNotificationRequest
{
    [JsonPropertyName("to")]
    public List<string> To { get; set; } = new();
    
    [JsonPropertyName("payload")]
    public object Payload { get; set; }
    
    [JsonPropertyName("actionUrl")]
    public string ActionUrl { get; set; }
}