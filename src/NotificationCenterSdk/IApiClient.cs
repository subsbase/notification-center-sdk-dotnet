namespace NotificationCenterSdk;

public interface IApiClient
{
    Task<TResponse> GetAsync<TResponse>(string path, bool requireAuth = true, Dictionary<string, string>? headers = null);
    Task<TResponse> PostAsync<TResponse>(string path, object body, TResponse response, bool requireAuth = true, Dictionary<string, string>? headers = null);
    Task<TResponse> PostAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null);
    Task<TResponse> PutAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null);
    Task<TResponse> PatchAsync<TResponse>(string path, object body, bool requireAuth = true, Dictionary<string, string>? headers = null);
}