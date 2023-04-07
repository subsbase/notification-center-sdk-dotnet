using Microsoft.Extensions.Logging;

namespace NotificationCenterSdk;

public class NotificationCenterSdkBuilder
{
    private string _uri;
    private string _apiSecret;

    public NotificationCenterSdkBuilder WithUri(string uri)
    {
        _uri = uri;
        return this;
    }

    public NotificationCenterSdkBuilder WithApiSecret(string apiSecret)
    {
        _apiSecret = _apiSecret;
        return this;
    }

    public INotificationCenterApi Build()
    {
        
        return new NotificationCenterApi(GetApiClient());
    }

    private IApiClient GetApiClient()
    {

        return new ApiClient(GetHttpClient(), GetCredentials() , GetLogger());
    }

    private NotificationCenterCredentials GetCredentials()
    {
        return new NotificationCenterCredentials(_apiSecret);
    }

    private HttpClient GetHttpClient()
    {
        return new HttpClient
        {
            BaseAddress = new Uri(_uri),
        };
    }

    private ILogger<ApiClient> GetLogger()
    {
        ILoggerFactory loggerFactory = new LoggerFactory();
        return loggerFactory.CreateLogger<ApiClient>();
    }
}