using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchProjectionParams))]
    public partial interface IProductSearchProjectionParams
    {
        IList<string> Expand { get; set; }

        IEnumerable<string> ExpandEnumerable { set => Expand = value.ToList(); }

        bool? Staged { get; set; }

        string PriceCurrency { get; set; }

        string PriceCountry { get; set; }

        string PriceCustomerGroup { get; set; }

        string PriceChannel { get; set; }

        IList<string> LocaleProjection { get; set; }

        IEnumerable<string> LocaleProjectionEnumerable { set => LocaleProjection = value.ToList(); }

        string StoreProjection { get; set; }

    }
}
