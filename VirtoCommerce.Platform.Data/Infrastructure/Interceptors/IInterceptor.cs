﻿namespace VirtoCommerce.Platform.Data.Infrastructure.Interceptors
{
    public interface IInterceptor
    {
        void Before(InterceptionContext context);

        void After(InterceptionContext context);
    }
}
