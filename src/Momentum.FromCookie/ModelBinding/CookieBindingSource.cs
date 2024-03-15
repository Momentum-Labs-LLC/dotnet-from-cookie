using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Momentum.FromCookie.ModelBinding
{
    public static class CookieBindingSource
    {
        public static readonly BindingSource CookieSource = new BindingSource(nameof(CookieSource), nameof(CookieSource), false, true);
    } // end method
} // end namespace