using Microsoft.AspNetCore.Mvc.ModelBinding;
using Momentum.FromCookie.ModelBinding;

namespace Momentum.FromCookie
{
    //
    // Summary:
    //     Specifies that a parameter or property should be bound using the request headers.
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public class FromCookieAttribute : Attribute, IBindingSourceMetadata, IModelNameProvider
    {        
        public BindingSource? BindingSource => CookieBindingSource.CookieSource;

        public string? Name { get; set; }
    } // end class
} // end namespace