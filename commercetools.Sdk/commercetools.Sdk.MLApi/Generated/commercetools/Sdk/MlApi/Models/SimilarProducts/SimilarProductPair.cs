using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductPair : ISimilarProductPair
    {
        public decimal Confidence { get; set; }

        public List<ISimilarProduct> Products { get; set; }
    }
}
