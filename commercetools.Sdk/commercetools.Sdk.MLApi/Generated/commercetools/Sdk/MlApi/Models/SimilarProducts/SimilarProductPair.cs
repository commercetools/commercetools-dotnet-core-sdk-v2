using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductPair : ISimilarProductPair
    {
        public decimal Confidence { get; set; }

        public IList<ISimilarProduct> Products { get; set; }
        public IEnumerable<ISimilarProduct> ProductsEnumerable { set => Products = value.ToList(); }

    }
}
