using NotificationCenterSdk.Topics;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class CreateSubjectRequest
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("topics")]
    public Dictionary<string, Topic> Topics = new();
}