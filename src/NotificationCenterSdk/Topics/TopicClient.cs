namespace NotificationCenterSdk.Topics;

public class TopicClient : BaseClient, ITopicsClient
{
    private readonly IApiClient _apiClient;

    public TopicClient(IApiClient apiClient)
        : base(apiClient, Constants.TOPICS_PATH)
    {
    }

    public Task<CreateTopicResponse> CreateTopicAsync( CreateTopicRequest topic)
    {
        return ApiClient.PostAsync<CreateTopicResponse>($"{Path}/{topic.SubjectId}", topic);
    }

    public Task<UpdateTopicResponse> UpdateTopicAsync( UpdateTopicRequest topic)
    {
        return ApiClient.PutAsync<UpdateTopicResponse>($"{Path}/{topic.SubjectId}/{topic.TopicId}", topic.Topic);
    }
   

    public Task<CreateNotificationTemplateResponse> SetNotificationTemplateAsync(CreateNotificationTemplateRequest request)
    {
        return ApiClient.PostAsync<CreateNotificationTemplateResponse>($"{Path}/{request.SubjectId}/{request.TopicId}", request.Template);
    }
    
    public Task<Topic>  GetByIdAsync(string subjectId, string topicId) 
    {
        return ApiClient.GetAsync<Topic>($"{Path}/{subjectId}/{topicId}");
    }
}