using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class CountUnreadResponse
{
    [JsonPropertyNameAttribute("count")]
    public int count { get; set; }
}