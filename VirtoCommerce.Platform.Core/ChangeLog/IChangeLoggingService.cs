using System;
using System.Collections.Generic;

namespace VirtoCommerce.Platform.Core.ChangeLog
{
    public interface IChangeLogService
    {
        IEnumerable<OperationLog> SaveChanges(params OperationLog[] operationLogs);

        IEnumerable<OperationLog> FindChangeHistory(string objectType, DateTime? startDate, DateTime? endDate);

        IEnumerable<OperationLog> FindObjectChangeHistory(string objectId, string objectType);

        OperationLog GetObjectLastChange(string objectId, string objectType);

        void LoadChangeLogs(IHasChangesHistory owner);
    }
}
