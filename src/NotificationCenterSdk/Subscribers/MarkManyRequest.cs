namespace NotificationCenterSdk.Subscribers;

public class MarkManyRequest
{
    public string SubscriberId { get; set; }
    public IEnumerable<string> NotificationsIds { get; set; } 
}