using System.Text.Json.Serialization;

namespace NotificationCenterSdk;

public class NotificationCenterCredentials
{
    public NotificationCenterCredentials(string apiSecret)
    {
        apiSecret = apiSecret;
    }
    
    [JsonPropertyName("apiSecret")]
    public string ApiSecret { get; }
}