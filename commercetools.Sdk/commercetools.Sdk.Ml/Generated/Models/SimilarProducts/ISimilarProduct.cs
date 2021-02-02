using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Ml.Models.SimilarProducts.SimilarProduct))]
    public partial interface ISimilarProduct 
    {
        IProductReference Product { get; set;}
        
        long? VariantId { get; set;}
        
        ISimilarProductMeta Meta { get; set;}
    }
}
