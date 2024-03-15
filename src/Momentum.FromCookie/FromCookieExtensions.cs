using Microsoft.AspNetCore.Mvc;
using Momentum.FromCookie.ModelBinding;

namespace Momentum.FromCookie
{
    public static class FromCookieExtensions
    {
        public static MvcOptions AddFromCookieBinder(this MvcOptions options)
        {
            options.ValueProviderFactories.Add(new CookieValueProviderFactory());
            return options;
        } // end method
    } // end class
} // end namespace