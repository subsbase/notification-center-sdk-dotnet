namespace NotificationCenterSdk.Subscribers;

public class ArchiveNotificationRequest
{
    public string SubscriberId { get; set; }
    public IEnumerable<string> NotificationIds { get; set; } 
}