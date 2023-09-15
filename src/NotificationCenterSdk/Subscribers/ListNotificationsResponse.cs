using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class ListNotificationsResponse
{
    [JsonPropertyName("notifications")]
    public IEnumerable<Notification> Notifications { get; set; } 
    
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; set; }
}