using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class Subscriber
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("realm")]
    public string Realm { get; set; }
    
    [JsonPropertyName("customData")]
    public Dictionary<string,string> CustomData { get; set; }
    
    [JsonPropertyName("notifications")]
    public IEnumerable<Notification> Notifications { get; set; }
    
    [JsonPropertyName("archivedNotifications")]
    public IEnumerable<ArchivedNotification>  ArchivedNotifications { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}