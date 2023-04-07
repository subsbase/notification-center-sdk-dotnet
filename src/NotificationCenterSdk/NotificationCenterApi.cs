using NotificationCenterSdk.Notifications;
using NotificationCenterSdk.Subjects;
using NotificationCenterSdk.Subscribers;
using NotificationCenterSdk.Topics;

namespace NotificationCenterSdk;

public class NotificationCenterApi : INotificationCenterApi
{
    private readonly INotificationsClient _notificationsClient;
    private readonly ISubscribersClient _subscribersClient;
    private readonly ISubjectsClient _subjectsClient;
    private readonly ITopicsClient _topicsClient;
    
    public NotificationCenterApi(IApiClient apiClient)
    {
        _notificationsClient = new NotificationsClient(apiClient);
        _subscribersClient = new SubscribersClient(apiClient);
        _subjectsClient = new SubjectsClient(apiClient);
        _topicsClient = new TopicClient(apiClient);
    }
    
    public INotificationsClient NotificationsClient()
    {
        return _notificationsClient;
    }

    public ISubscribersClient SubscribersClient()
    {
        return _subscribersClient;
    }

    public ISubjectsClient SubjectsClient()
    {
        return _subjectsClient;
    }

    public ITopicsClient TopicsClient()
    {
        return _topicsClient;
    }
}