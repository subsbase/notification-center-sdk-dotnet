namespace NotificationCenterSdk.Topics;

public interface ITopicsClient
{
    Task<CreateTopicResponse> CreateTopicAsync( CreateTopicRequest topic);

    Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest topic);

    Task<CreateNotificationTemplateResponse> SetNotificationTemplateAsync( CreateNotificationTemplateRequest request);
    Task<Topic> GetByIdAsync(string subjectId, string topicId);
}