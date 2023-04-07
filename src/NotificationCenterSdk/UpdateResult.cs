using System.Text.Json.Serialization;

namespace NotificationCenterSdk;

public class UpdateResult
{
    [JsonPropertyName("matchedCount")]
    public int MatchedCount { get; set; }
    
    [JsonPropertyName("modifiedCount")]
    public int ModifiedCount { get; set; }
    
    [JsonPropertyName("acknowledged")]
    public bool Acknowledged { get; set; }
    
    [JsonPropertyName("upsertedId")]
    public IEnumerable<string> UpsertedIds { get; set; }
    
    [JsonPropertyName("upsertedCount")]
    public int UpsertedCount { get; set; }
}