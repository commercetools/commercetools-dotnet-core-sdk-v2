using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductsPagedQueryResult))]
    public partial interface ISimilarProductsPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<ISimilarProductPair> Results { get; set; }

        ISimilarProductSearchRequestMeta Meta { get; set; }

    }
}
