namespace VirtoCommerce.Platform.Core.Notifications
{
    public class SmsNotification : Notification
    {
        public SmsNotification(ISmsNotificationSendingGateway gateway) : base(gateway)
        {
        }
    }
}
