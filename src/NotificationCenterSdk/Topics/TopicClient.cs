namespace NotificationCenterSdk.Topics;

public class TopicClient : BaseClient, ITopicsClient
{
    private readonly IApiClient _apiClient;

    public TopicClient(IApiClient apiClient)
        : base(apiClient, Constants.TOPICS_PATH)
    {
    }

    public Task<CreateTopicResult> CreateTopicAsync(string subjectId, CreateTopicRequest topic)
    {
        return ApiClient.PostAsync<CreateTopicResult>($"{Path}/{subjectId}", topic);
    }

    public Task<UpdateTopicResult> UpdateTopicAsync(string subjectId, string topicId, Topic topic)
    {
        return ApiClient.PutAsync<UpdateTopicResult>($"{Path}/{subjectId}/{topicId}", topic);
    }

    public Task<CreateNotificationTemplateResult> SetNotificationTemplateAsync(string subjectId, string topicId, CreateNotificationTemplateRequest request)
    {
        return ApiClient.PostAsync<CreateNotificationTemplateResult>($"{Path}/{subjectId}/{topicId}", request);
    }
}