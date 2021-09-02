using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProductsPagedQueryResult))]
    public partial interface ISimilarProductsPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<ISimilarProductPair> Results { get; set; }

        ISimilarProductSearchRequestMeta Meta { get; set; }
    }
}
