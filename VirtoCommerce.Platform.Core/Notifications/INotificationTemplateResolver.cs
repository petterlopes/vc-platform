namespace VirtoCommerce.Platform.Core.Notifications
{
    public interface INotificationTemplateResolver
    {
        void ResolveTemplate(Notification notification);

        NotificationParameter[] ResolveNotificationParameters(Notification notification);
    }
}
