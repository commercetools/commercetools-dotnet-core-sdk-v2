using commercetools.Ml.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    public partial class SimilarProductSearchRequestMeta : ISimilarProductSearchRequestMeta
    {
        public ISimilarityMeasures SimilarityMeasures { get; set;}
    }
}
