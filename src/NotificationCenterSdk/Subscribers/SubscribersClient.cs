namespace NotificationCenterSdk.Subscribers;

public class SubscribersClient : BaseClient, ISubscribersClient
{
    public SubscribersClient(IApiClient apiClient)
        : base(apiClient, Constants.SUBSCRIBERS_PATH)
    {
    }

    public Task<CreateSubscriberResult> CreateSubscriberAsync(Subscriber subscriber)
    {
        return ApiClient.PostAsync<CreateSubscriberResult>(Path, subscriber);
    }

    public Task<IEnumerable<Notification>> GetSubscriberNotificationAsync(string subscriberId, int pageIndex, int pageLimit)
    {
        return ApiClient.GetAsync<IEnumerable<Notification>>($"{Path}/{subscriberId}/notifications");
    }

    public Task MarkNotificationsAsReadAsync(string subscriberId, IEnumerable<string> notificationsIds)
    {
        return ApiClient.PatchAsync<object>($"{Path}/{subscriberId}/marksomeasread", notificationsIds);
    }
}