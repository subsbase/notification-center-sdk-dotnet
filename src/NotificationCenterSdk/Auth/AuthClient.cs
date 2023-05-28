namespace NotificationCenterSdk.Auth;

public class AuthClient :BaseClient, IAuthClient
{
    public AuthClient(IApiClient apiClient) 
        : base(apiClient, Constants.AUTH_PATH)
    {
    }
    
    public async Task<string> GetAccessTokenAsync(AuthRequest request)
    {
       AuthResponse authResponse = await ApiClient.PostAsync<AuthResponse>(Path, request, requireAuth: false);
       return authResponse.AccessToken;
    }
}