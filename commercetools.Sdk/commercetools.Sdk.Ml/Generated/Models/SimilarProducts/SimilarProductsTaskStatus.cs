using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    public partial class SimilarProductsTaskStatus : ISimilarProductsTaskStatus
    {
        public ITaskStatusEnum State { get; set;}
        
        public DateTime Expires { get; set;}
        
        public ISimilarProductsPagedQueryResult Result { get; set;}
    }
}
