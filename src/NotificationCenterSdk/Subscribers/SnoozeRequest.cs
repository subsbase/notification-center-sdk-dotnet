using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class SnoozeRequest
{
    public string SubscriberId { get; set; }
    public SnoozeRequestBody Body { get; set; } 


    public class SnoozeRequestBody
    {
        [JsonPropertyName("notificationsIds")]
        public List<string> NotificationsIds { get; set; }
        [JsonPropertyName("snoozeUntil")] 
        public DateTime SnoozeUntil { get; set; }
    }

}