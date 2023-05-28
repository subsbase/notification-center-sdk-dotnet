using System.Text.Json.Serialization;

namespace NotificationCenterSdk;

public class NotificationCenterCredentials
{
    public NotificationCenterCredentials(string apiSecret, string realm)
    {
        ApiSecret = apiSecret;
        Realm = realm;
    }
    
    public string ApiSecret { get; }
    
    public string Realm { get; }
}