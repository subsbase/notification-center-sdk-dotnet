namespace NotificationCenterSdk.Subscribers;

public interface ISubscribersClient
{
    Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request);
    Task<SnoozeResponse> SnoozeNotificationsAsync(SnoozeRequest snoozeRequest);
    Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest listNotificationsRequest);
    Task<CountUnreadResponse> CountUnreadNotificationsAsync(string subscriberId);
    Task<ListNotificationsResponse> listArchivedNotificationsAsync(ListNotificationsRequest listNotificationsRequest);
    Task markAsReadAsync(MarkNotificationRequest markNotificationRequest);
    Task markAsUnreadAsync(MarkNotificationRequest markNotificationRequest);
    Task markAllAsReadAsync(string subscriberId);
    Task markAllAsUnreadAsync(string subscriberId);
    Task markManyAsReadAsync(MarkManyRequest markManyRequest);
    Task markManyAsUnreadAsync(MarkManyRequest markManyRequest);
    
     Task<ArchiveNotificationResponse> ArchiveNotificationAsync(ArchiveNotificationRequest archiveNotificationRequest);
     Task<ArchiveNotificationResponse> UnarchiveNotificationAsync(ArchiveNotificationRequest unarchiveNotificationRequest);
    
}