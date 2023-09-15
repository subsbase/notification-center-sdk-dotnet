using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class SnoozeNotificationRequest
{
    public string SubscriberId { get; set; }
    public SnoozeNotificationRequestBody RequestedData { get; set; } 


    public class SnoozeNotificationRequestBody
    {
        [JsonPropertyName("notificationsIds")]
        public List<string> NotificationsIds { get; set; }
        [JsonPropertyName("snoozeUntil")] 
        public DateTime SnoozeUntil { get; set; }
    }

}