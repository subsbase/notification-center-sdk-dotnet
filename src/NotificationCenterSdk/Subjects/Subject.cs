using NotificationCenterSdk.Topics;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class Subject: BaseRequest
{
 
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
   
    [JsonPropertyName("topics")]
    public Dictionary<string, Topic> Topics = new();
    
   
}