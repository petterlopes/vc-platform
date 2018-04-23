using System;
using System.Reflection;

namespace VirtoCommerce.Platform.Core.Common
{
    public static class PlatformVersion
    {
        public static SemanticVersion CurrentVersion
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                Version version;
                if (!Version.TryParse(assembly.GetInformationalVersion(), out version))
                {
                    throw new FormatException("version");
                }
                version = new Version(version.Major, version.Minor, Convert.ToInt32(assembly.GetFileVersion()));
                return new SemanticVersion(version);
            }
        }
    }
}
