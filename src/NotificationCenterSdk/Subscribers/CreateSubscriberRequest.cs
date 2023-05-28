using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class CreateSubscriberRequest
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("customData")]
    public Dictionary<string,string> CustomData { get; set; }
}