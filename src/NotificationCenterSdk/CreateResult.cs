using System.Text.Json.Serialization;

namespace NotificationCenterSdk;

public class CreateResult
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("created")]
    public bool Created { get; set; }
}