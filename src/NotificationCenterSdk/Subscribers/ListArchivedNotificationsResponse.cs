using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class ListArchivedNotificationsResponse
{
    [JsonPropertyName("archivedNotifications")]
    public IEnumerable<ArchivedNotification> ArchivedNotifications { get; set; } 
    
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; set; }

}