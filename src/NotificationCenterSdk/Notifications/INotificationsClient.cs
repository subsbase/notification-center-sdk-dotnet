namespace NotificationCenterSdk.Notifications;

public interface INotificationsClient
{
    Task TriggerAsync(string subjectId, string topicId, TriggerNotificationRequest request);
}