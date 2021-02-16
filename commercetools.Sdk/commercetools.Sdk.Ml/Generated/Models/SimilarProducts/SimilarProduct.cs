using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    public partial class SimilarProduct : ISimilarProduct
    {
        public IProductReference Product { get; set;}
        
        public long? VariantId { get; set;}
        
        public ISimilarProductMeta Meta { get; set;}
    }
}
