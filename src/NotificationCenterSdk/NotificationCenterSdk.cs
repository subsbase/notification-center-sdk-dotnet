namespace NotificationCenterSdk;

public sealed class NotificationCenterSdk
{
    private NotificationCenterSdk()
    {
    }

    public static NotificationCenterSdkBuilder Builder()
    {
        return new NotificationCenterSdkBuilder();
    }
}