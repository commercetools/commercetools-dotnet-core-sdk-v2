using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.SimilarProductPair))]
    public partial interface ISimilarProductPair
    {
        double Confidence { get; set; }

        List<ISimilarProduct> Products { get; set; }
    }
}
