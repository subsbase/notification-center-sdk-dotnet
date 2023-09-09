namespace NotificationCenterSdk.Topics;

public class TopicClient : BaseClient, ITopicsClient
{
    private readonly IApiClient _apiClient;

    public TopicClient(IApiClient apiClient)
        : base(apiClient, Constants.TOPICS_PATH)
    {
    }

    public Task<CreateTopicResult> CreateTopicAsync( CreateTopicRequest topic)
    {
        return ApiClient.PostAsync<CreateTopicResult>($"{Path}/{topic.SubjectId}", topic);
    }

    public Task<UpdateTopicResult> UpdateTopicAsync( UpdateTopicRequest topic)
    {
        return ApiClient.PutAsync<UpdateTopicResult>($"{Path}/{topic.SubjectId}/{topic.TopicId}", topic.Topic);
    }
   

    public Task<CreateNotificationTemplateResult> SetNotificationTemplateAsync(CreateNotificationTemplateRequest request)
    {
        return ApiClient.PostAsync<CreateNotificationTemplateResult>($"{Path}/{request.SubjectId}/{request.TopicId}", request.Template);
    }
    
    public Task<Topic>  GetByIdAsync(string subjectId, string topicId) 
    {
        return ApiClient.GetAsync<Topic>($"{Path}/{subjectId}/{topicId}");
    }
}