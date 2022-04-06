using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductPair : ISimilarProductPair
    {
        public double Confidence { get; set; }

        public List<ISimilarProduct> Products { get; set; }
    }
}
