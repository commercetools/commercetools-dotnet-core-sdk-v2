using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductSearchRequest : ISimilarProductSearchRequest
    {
        public long? Limit { get; set; }

        public long? Offset { get; set; }

        public string Language { get; set; }

        public string CurrencyCode { get; set; }

        public ISimilarityMeasures SimilarityMeasures { get; set; }

        public IList<IProductSetSelector> ProductSetSelectors { get; set; }
        public IEnumerable<IProductSetSelector> ProductSetSelectorsEnumerable { set => ProductSetSelectors = value.ToList(); }


        public decimal? ConfidenceMin { get; set; }

        public decimal? ConfidenceMax { get; set; }
    }
}
