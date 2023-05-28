namespace NotificationCenterSdk.Auth;

public interface IAuthClient
{
    Task<string> GetAccessTokenAsync(AuthRequest request);
}