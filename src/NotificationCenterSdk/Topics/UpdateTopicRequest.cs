using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class UpdateTopicRequest
{
    
   
    public string SubjectId { get; set; }
    
    public string TopicId { get; set; }
   
    [JsonPropertyName("topic")]
    public Topic Topic { get; set; }
    
}