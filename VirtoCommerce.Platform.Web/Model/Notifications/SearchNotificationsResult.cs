using System.Collections.Generic;

namespace VirtoCommerce.Platform.Web.Model.Notifications
{
    public class SearchNotificationsResult
    {
        public ICollection<Notification> Notifications { get; set; }
        public int TotalCount { get; set; }
    }
}
