namespace NotificationCenterSdk;

public interface IApiClient
{
    Task<TResponse> GetAsync<TResponse>(string path, IDictionary<string, string>? headers = null);
    Task<TResponse> PostAsync<TResponse>(string path, object body, TResponse response, IDictionary<string, string>? headers = null);
    Task<TResponse> PostAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null);
    Task<TResponse> PutAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null);
    Task<TResponse> PatchAsync<TResponse>(string path, object body, IDictionary<string, string>? headers = null);
}