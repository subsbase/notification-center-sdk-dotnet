using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Notifications;

public class TriggerNotificationRequest
{
    [JsonPropertyName("to")]
    public List<string> To { get; set; } = new();
    
    [JsonPropertyName("actionUrl")]
    public string ActionUrl { get; set; }
    
    
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("message")]
    public string Message { get; set; }
    
    
    
    [JsonPropertyName("templateId")]
    public string TemplateId { get; set; }
    
    [JsonPropertyName("payload")]
    public object Payload { get; set; }
}