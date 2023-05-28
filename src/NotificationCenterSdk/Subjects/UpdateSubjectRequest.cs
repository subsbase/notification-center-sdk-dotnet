using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class UpdateSubjectRequest
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}