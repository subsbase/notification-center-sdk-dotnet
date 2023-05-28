namespace NotificationCenterSdk.Subscribers;

public interface ISubscribersClient
{
    Task<CreateSubscriberResult> CreateSubscriberAsync(Subscriber subscriber);
}