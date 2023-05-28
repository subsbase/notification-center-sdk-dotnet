namespace NotificationCenterSdk.Topics;

public interface ITopicsClient
{
    Task<CreateTopicResult> CreateTopicAsync(string subjectId, CreateTopicRequest topic);

    Task<UpdateTopicResult> UpdateTopicAsync(string subjectId, string topicId, Topic topic);

    Task<CreateNotificationTemplateResult> SetNotificationTemplateAsync(string subjectId, string topicId, CreateNotificationTemplateRequest request);
}