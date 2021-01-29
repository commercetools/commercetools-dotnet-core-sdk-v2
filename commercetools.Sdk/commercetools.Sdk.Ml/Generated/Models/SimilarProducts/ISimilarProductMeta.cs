using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Ml.Models.SimilarProducts.SimilarProductMeta))]
    public partial interface ISimilarProductMeta 
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        IMoney Price { get; set;}
        
        long? VariantCount { get; set;}
    }
}
