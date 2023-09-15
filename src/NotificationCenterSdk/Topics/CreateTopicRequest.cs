using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class CreateTopicRequest
{
    
    
    public string SubjectId { get; set; }
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("notificationTemplates")]
    public Dictionary<string, NotificationTemplate> NotificationTemplates { get; set; }
}