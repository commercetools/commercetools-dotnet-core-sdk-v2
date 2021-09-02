using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProductPair))]
    public partial interface ISimilarProductPair
    {
        double Confidence { get; set; }

        List<ISimilarProduct> Products { get; set; }
    }
}
