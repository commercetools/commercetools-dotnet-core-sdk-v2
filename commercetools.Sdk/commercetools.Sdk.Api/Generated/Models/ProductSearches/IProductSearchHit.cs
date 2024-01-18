using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchHit))]
    public partial interface IProductSearchHit
    {
        string Id { get; set; }

        IProductProjection ProductProjection { get; set; }

        IList<IProductSearchMatchingVariant> MatchingVariants { get; set; }
        IEnumerable<IProductSearchMatchingVariant> MatchingVariantsEnumerable { set => MatchingVariants = value.ToList(); }


    }
}
