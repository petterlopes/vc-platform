using VirtoCommerce.Platform.Core.Notifications;

namespace VirtoCommerce.Platform.Data.Notifications
{
    public class ResetPasswordEmailNotification : EmailNotification
    {
        public ResetPasswordEmailNotification(IEmailNotificationSendingGateway gateway)
            : base(gateway)
        {
        }

        [NotificationParameter("Reset password URL")]
        public string Url { get; set; }
    }
}
