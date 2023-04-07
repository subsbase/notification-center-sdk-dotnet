namespace NotificationCenterSdk.Subscribers;

public interface ISubscribersClient
{
    Task<CreateSubscriberResult> CreateSubscriberAsync(Subscriber subscriber);
    Task<IEnumerable<Notification>> GetSubscriberNotificationAsync(string subscriberId, int pageIndex, int pageLimit);
    Task MarkNotificationsAsReadAsync(string subscriberId, IEnumerable<string> notificationsIds);
}