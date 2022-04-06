using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductSearchRequest : ISimilarProductSearchRequest
    {
        public long? Limit { get; set; }

        public long? Offset { get; set; }

        public string Language { get; set; }

        public string CurrencyCode { get; set; }

        public ISimilarityMeasures SimilarityMeasures { get; set; }

        public List<IProductSetSelector> ProductSetSelectors { get; set; }

        public double? ConfidenceMin { get; set; }

        public double? ConfidenceMax { get; set; }
    }
}
