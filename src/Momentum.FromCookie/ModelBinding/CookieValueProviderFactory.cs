using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Momentum.FromCookie.ModelBinding
{
    public class CookieValueProviderFactory : IValueProviderFactory
    {
        public virtual Task CreateValueProviderAsync(ValueProviderFactoryContext context)
        {
            var cookies = context.ActionContext.HttpContext.Request.Cookies;

            context.ValueProviders.Add(new CookieValueProvider(CookieBindingSource.CookieSource, cookies));

            return Task.CompletedTask;
        } // end method
    } // end class
} // end namespace