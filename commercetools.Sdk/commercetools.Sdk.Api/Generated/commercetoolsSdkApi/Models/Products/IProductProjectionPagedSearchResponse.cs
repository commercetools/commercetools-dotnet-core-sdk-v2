using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductProjectionPagedSearchResponse))]
    public partial interface IProductProjectionPagedSearchResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IProductProjection> Results { get; set; }

        IEnumerable<IProductProjection> ResultsEnumerable { set => Results = value.ToList(); }

        IFacetResults Facets { get; set; }

    }
}
