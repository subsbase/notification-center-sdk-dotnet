using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Auth;

public class AuthRequest
{
    [JsonPropertyName("apiSecret")]
    public string ApiSecret { get; set; }
}