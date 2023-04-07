using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class Subscriber
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    
    [JsonPropertyName("subscriberId")]
    public  string SubscriberId { get; set; }

    [JsonPropertyName("realm")]
    public string realmId { get; set; }
    
    [JsonPropertyName("customData")]
    public object CustomData { get; set; }
    
    [JsonPropertyName("notifications")]
    public IEnumerable<Notification> Notifications { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}