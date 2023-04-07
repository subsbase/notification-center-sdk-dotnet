using NotificationCenterSdk.Notifications;
using NotificationCenterSdk.Subjects;
using NotificationCenterSdk.Subscribers;
using NotificationCenterSdk.Topics;

namespace NotificationCenterSdk;

public interface INotificationCenterApi
{
    INotificationsClient NotificationsClient();

    ISubscribersClient SubscribersClient();

    ISubjectsClient SubjectsClient();
    
    ITopicsClient TopicsClient();
}