using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class CreateNotificationTemplateRequest
{
    
    public string SubjectId { get; set; }
    public string TopicId { get; set; }
    
    public NotificationTemplate Template { get; set; }
    
    public class NotificationTemplate
    {
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }
    
        [JsonPropertyName("titleTemplate")]
        public string TitleTemplate { get; set; }
    
        [JsonPropertyName("messageTemplate")]
        public string MessageTemplate { get; set; }
    }
}