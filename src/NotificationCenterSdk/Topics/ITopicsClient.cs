namespace NotificationCenterSdk.Topics;

public interface ITopicsClient
{
    Task<CreateTopicResult> CreateTopicAsync(Topic topic);
}