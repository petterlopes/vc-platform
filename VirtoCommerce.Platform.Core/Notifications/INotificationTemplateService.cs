﻿using System.Collections.Generic;

namespace VirtoCommerce.Platform.Core.Notifications
{
    public interface INotificationTemplateService
    {
        IEnumerable<NotificationTemplate> GetAllTemplates();

        NotificationTemplate GetById(string notificationTemplateId);

        NotificationTemplate GetByNotification(string notificationTypeId, string objectId, string objectTypeId, string language);

        NotificationTemplate[] GetNotificationTemplatesByNotification(string notificationTypeId, string objectId, string objectTypeId);

        NotificationTemplate Create(NotificationTemplate notificationTemplate);

        void Update(NotificationTemplate[] notificationTemplates);

        void Delete(string[] notificationTemplateIds);
    }
}
