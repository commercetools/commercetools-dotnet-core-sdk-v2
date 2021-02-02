using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Ml.Models.SimilarProducts.SimilarProductSearchRequestMeta))]
    public partial interface ISimilarProductSearchRequestMeta 
    {
        ISimilarityMeasures SimilarityMeasures { get; set;}
    }
}
