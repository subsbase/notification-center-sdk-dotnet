namespace NotificationCenterSdk.Topics;

public interface ITopicsClient
{
    Task<CreateTopicResult> CreateTopicAsync( CreateTopicRequest topic);

    Task<UpdateTopicResult> UpdateTopicAsync(UpdateTopicRequest topic);

    Task<CreateNotificationTemplateResult> SetNotificationTemplateAsync( CreateNotificationTemplateRequest request);
}