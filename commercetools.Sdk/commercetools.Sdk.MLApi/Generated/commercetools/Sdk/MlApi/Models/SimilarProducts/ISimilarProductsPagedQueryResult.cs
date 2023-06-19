using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductsPagedQueryResult))]
    public partial interface ISimilarProductsPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<ISimilarProductPair> Results { get; set; }
        IEnumerable<ISimilarProductPair> ResultsEnumerable { set => Results = value.ToList(); }


        ISimilarProductSearchRequestMeta Meta { get; set; }

    }
}
