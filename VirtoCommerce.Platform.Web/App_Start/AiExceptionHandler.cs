using System.Web.Http.ExceptionHandling;
using Microsoft.ApplicationInsights;

namespace VirtoCommerce.Platform.Web.App_Start
{
    public class AiExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            if (context != null && context.Exception != null)
            {
                var ai = new TelemetryClient();
                ai.TrackException(context.Exception);
            }
            base.Handle(context);
        }
    }
}
