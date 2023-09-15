using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Subscribers;

public class ListNotificationsRequest
{
    public string SubscriberId { get; set; }

    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}