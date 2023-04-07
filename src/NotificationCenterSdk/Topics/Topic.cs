using NotificationCenterSdk.Subscribers;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class Topic
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    
    [JsonPropertyName("event")]
    public string Event {get; set; }
    
    [JsonPropertyName("subject")]
    public string SubjectId { get; set; }
    
    [JsonPropertyName("notificationTemplate")]
    public string NotificationTemplateId { get; set; }

    [JsonPropertyName("realm")]
    public string realmId { get; set; }

    [JsonPropertyName("parentTopic")]
    public string ParentTopicId { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}