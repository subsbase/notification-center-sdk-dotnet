using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class ArchivedNotification : Notification
{
    [JsonPropertyName("archivedAt")]
    public DateTime ArchivedAt { get; set; }
}