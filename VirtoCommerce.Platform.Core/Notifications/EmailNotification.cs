namespace VirtoCommerce.Platform.Core.Notifications
{
    public abstract class EmailNotification : Notification
    {
        protected EmailNotification(IEmailNotificationSendingGateway gateway) : base(gateway)
        {
        }
    }
}
