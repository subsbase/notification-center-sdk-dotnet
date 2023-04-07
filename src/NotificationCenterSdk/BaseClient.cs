namespace NotificationCenterSdk;

public abstract class BaseClient
{
    public BaseClient(IApiClient apiClient, string path)
    {
        ApiClient = apiClient;
        Path = path;
    }
    
    protected IApiClient ApiClient { get; }
    protected string Path { get; }
}