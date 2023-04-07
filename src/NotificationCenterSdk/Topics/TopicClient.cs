namespace NotificationCenterSdk.Topics;

public class TopicClient : BaseClient, ITopicsClient
{
    private readonly IApiClient _apiClient;

    public TopicClient(IApiClient apiClient)
        : base(apiClient, Constants.TOPICS_PATH)
    {
    }

    public Task<CreateTopicResult> CreateTopicAsync(Topic topic)
    {
        return ApiClient.PostAsync<CreateTopicResult>(Path, topic);
    }
}