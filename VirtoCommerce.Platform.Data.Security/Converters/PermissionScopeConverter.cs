using Omu.ValueInjecter;
using VirtoCommerce.Platform.Core.Security;
using dataModel = VirtoCommerce.Platform.Data.Model;

namespace VirtoCommerce.Platform.Data.Security.Converters
{
    public static class PermissionScopeConverter
    {
        public static PermissionScope ToCoreModel(this dataModel.PermissionScopeEntity source, PermissionScope permissionScope)
        {
            permissionScope.InjectFrom(source);
            return permissionScope;
        }

        public static dataModel.PermissionScopeEntity ToDataModel(this PermissionScope source)
        {
            var result = new dataModel.PermissionScopeEntity();
            result.InjectFrom(source);
            return result;
        }
    }
}
