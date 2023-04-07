namespace NotificationCenterSdk.Notifications;

public interface INotificationsClient
{
    Task TriggerAsync(string topicEvent, TriggerNotificationRequest request);
}