using System.Collections.Generic;

namespace VirtoCommerce.Platform.Core.ChangeLog
{
    public interface IHasChangesHistory
    {
        string Id { get; set; }
        ICollection<OperationLog> OperationsLog { get; set; }
    }
}
