namespace NotificationCenterSdk.Subscribers;

public interface ISubscribersClient
{
    Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request);
    Task<SnoozeNotificationResponse> SnoozeNotificationsAsync(SnoozeNotificationRequest snoozeRequest);
    Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest listNotificationsRequest);
    Task<CountUnreadResponse> CountUnreadNotificationsAsync(string subscriberId);
    Task<ListNotificationsResponse> ListArchivedNotificationsAsync(ListNotificationsRequest listNotificationsRequest);
    Task MarkAsReadAsync(MarkNotificationRequest markNotificationRequest);
    Task MarkAsUnreadAsync(MarkNotificationRequest markNotificationRequest);
    Task MarkAllAsReadAsync(string subscriberId);
    Task MarkAllAsUnreadAsync(string subscriberId);
    Task MarkManyAsReadAsync(MarkManyRequest markManyRequest);
    Task MarkManyAsUnreadAsync(MarkManyRequest markManyRequest);
    
     Task<ArchiveNotificationResponse> ArchiveNotificationAsync(ArchiveNotificationRequest archiveNotificationRequest);
     Task<ArchiveNotificationResponse> UnarchiveNotificationAsync(ArchiveNotificationRequest unarchiveNotificationRequest);
    
}