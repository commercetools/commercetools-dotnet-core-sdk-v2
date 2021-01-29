using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    public partial class SimilarProductsPagedQueryResult : ISimilarProductsPagedQueryResult
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ISimilarProductPair> Results { get; set;}
        
        public ISimilarProductSearchRequestMeta Meta { get; set;}
    }
}
