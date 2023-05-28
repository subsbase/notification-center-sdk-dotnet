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
}