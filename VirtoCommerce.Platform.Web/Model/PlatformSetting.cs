using System.Web.Mvc;

namespace VirtoCommerce.Platform.Web.Model
{
    /// <summary>
    /// Represent global platform settings
    /// </summary>
    public class PlatformSetting
    {
        public MvcHtmlString PlatformVersion { get; set; }
        public MvcHtmlString DemoCredentials { get; set; }
        public MvcHtmlString DemoResetTime { get; set; }
        public MvcHtmlString License { get; set; }
    }
}
