using System.Collections.Generic;
using System.Linq;
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

        IList<IProductSetSelector> ProductSetSelectors { get; set; }
        IEnumerable<IProductSetSelector> ProductSetSelectorsEnumerable { set => ProductSetSelectors = value.ToList(); }


        decimal? ConfidenceMin { get; set; }

        decimal? ConfidenceMax { get; set; }

    }
}
