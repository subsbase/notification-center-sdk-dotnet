using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Auth;

public class AuthResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}