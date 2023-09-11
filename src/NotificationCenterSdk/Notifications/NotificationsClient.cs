namespace NotificationCenterSdk.Notifications;

public class NotificationsClient : BaseClient, INotificationsClient
{
    public NotificationsClient(IApiClient apiClient)
        : base(apiClient, Constants.NOTIFICATIONS_PATH)
    {
    }

    public Task TriggerAsync(string subjectId, string topicId, TriggerNotificationRequest request)
    {
        return ApiClient.PostAsync<object>($"{Path}/trigger/{subjectId}/{topicId}", request);
    }
    
    
}