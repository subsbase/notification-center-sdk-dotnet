namespace NotificationCenterSdk.Subscribers;

public class SubscribersClient : BaseClient, ISubscribersClient
{
    public SubscribersClient(IApiClient apiClient)
        : base(apiClient, Constants.SUBSCRIBERS_PATH)
    {
    }

    public Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request)
    {
        return ApiClient.PostAsync<CreateSubscriberResponse>(Path, request);
    }
    
    public Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest listNotificationsRequest)
    {
        return ApiClient.GetAsync<ListNotificationsResponse>($"{Path}/{listNotificationsRequest.SubscriberId}/notifications?pageNum={listNotificationsRequest.PageNumber}&pageSize={listNotificationsRequest.PageSize}", false);
    }

  
    public Task<CountUnreadResponse> CountUnreadNotificationsAsync(string subscriberId)
    {
        return ApiClient.GetAsync<CountUnreadResponse>($"{Path}/{subscriberId}/notifications/countunread", false);
    }

    public Task<ListNotificationsResponse> ListArchivedNotificationsAsync(ListNotificationsRequest listNotificationsRequest)
    {
        
        
        return ApiClient.GetAsync<ListNotificationsResponse>($"{Path}/{listNotificationsRequest.SubscriberId}/notifications/archived?pageNum={listNotificationsRequest.PageNumber}&pageSize={listNotificationsRequest.PageSize}", false);

        
    }
    
    public Task MarkAsReadAsync(MarkNotificationRequest markNotificationRequest)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{markNotificationRequest.SubscriberId}/notifications/{markNotificationRequest.NotificationId}/markasread", false);
    }
    
    public Task MarkAsUnreadAsync(MarkNotificationRequest markNotificationRequest)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{markNotificationRequest.SubscriberId}/notifications/{markNotificationRequest.NotificationId}/markasunread", false);
    }
    
    public Task MarkAllAsReadAsync(string subscriberId)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{subscriberId}/notifications/markasread", false);
    }
    
    public Task MarkAllAsUnreadAsync(string subscriberId)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{subscriberId}/notifications/markasunread", false);
    }
    
    public Task MarkManyAsReadAsync(MarkManyRequest markManyRequest)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{markManyRequest.SubscriberId}/notifications/markmanyasread", markManyRequest.NotificationsIds, false);
    }
    
    public Task MarkManyAsUnreadAsync(MarkManyRequest markManyRequest)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{markManyRequest.SubscriberId}/notifications/markmanyasunread", markManyRequest.NotificationsIds, false);
    }
    
public Task<ArchiveNotificationResponse> ArchiveNotificationAsync(ArchiveNotificationRequest archiveNotificationRequest)
    {
        return ApiClient.PutAsync<ArchiveNotificationResponse>($"{Path}/{archiveNotificationRequest.SubscriberId}/notifications/archive",archiveNotificationRequest.NotificationIds, false);
    }
public Task<ArchiveNotificationResponse> UnarchiveNotificationAsync(ArchiveNotificationRequest archiveNotificationRequest)
    {
        return ApiClient.PutAsync<ArchiveNotificationResponse>($"{Path}/{archiveNotificationRequest.SubscriberId}/notifications/unarchive",archiveNotificationRequest.NotificationIds, false);
    }
    public Task<SnoozeNotificationResponse> SnoozeNotificationsAsync(SnoozeNotificationRequest snoozeNotificationRequest)
    {
        return ApiClient.PostAsync<SnoozeNotificationResponse>($"{Path}/{snoozeNotificationRequest.SubscriberId}/notifications/snooze", snoozeNotificationRequest.RequestData, false);
    }
    
        
    }
    
    
    
    
