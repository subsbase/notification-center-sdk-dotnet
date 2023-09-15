using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subjects;

public class ListSubjectsRequest
{
    [JsonPropertyNameAttribute("pageNum")] 
    public int PageNumber { get; set; }
    
    [JsonPropertyNameAttribute("pageSize")]
    public int PageSize { get; set; }
}