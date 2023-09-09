using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class NotificationTemplate
{
    
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
    
}