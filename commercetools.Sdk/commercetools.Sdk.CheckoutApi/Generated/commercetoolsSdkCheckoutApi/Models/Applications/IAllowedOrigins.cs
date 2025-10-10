using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AllowedOrigins))]
    public partial interface IAllowedOrigins
    {
        bool AllowAll { get; set; }

        IList<string> Origins { get; set; }

        IEnumerable<string> OriginsEnumerable { set => Origins = value.ToList(); }

    }
}
