using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class CreateNotificationTemplateRequest
{
    [JsonPropertyName("templateId")]
    public string TemplateId { get; set; }
    
    [JsonPropertyName("titleTemplate")]
    public string TitleTemplate { get; set; }
    
    [JsonPropertyName("messageTemplate")]
    public string MessageTemplate { get; set; }
}