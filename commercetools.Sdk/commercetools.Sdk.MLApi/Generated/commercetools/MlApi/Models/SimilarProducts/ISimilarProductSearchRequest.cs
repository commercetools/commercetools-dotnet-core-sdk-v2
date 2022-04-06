using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductSearchRequest))]
    public partial interface ISimilarProductSearchRequest
    {
        long? Limit { get; set; }

        long? Offset { get; set; }

        string Language { get; set; }

        string CurrencyCode { get; set; }

        ISimilarityMeasures SimilarityMeasures { get; set; }

        List<IProductSetSelector> ProductSetSelectors { get; set; }

        double? ConfidenceMin { get; set; }

        double? ConfidenceMax { get; set; }
    }
}
