using System.Collections.Generic;

namespace VirtoCommerce.Platform.Core.Security
{
    public interface IHasSecurityAccounts
    {
        /// <summary>
        /// All security accounts
        /// </summary>
        ICollection<ApplicationUserExtended> SecurityAccounts { get; }
    }
}
