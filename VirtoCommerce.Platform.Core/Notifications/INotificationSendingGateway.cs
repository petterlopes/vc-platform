namespace VirtoCommerce.Platform.Core.Notifications
{
    public interface INotificationSendingGateway
    {
        SendNotificationResult SendNotification(Notification notification);

        bool ValidateNotification(Notification notification);
    }
}
