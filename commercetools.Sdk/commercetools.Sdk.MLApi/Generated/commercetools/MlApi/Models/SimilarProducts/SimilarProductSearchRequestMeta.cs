using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductSearchRequestMeta : ISimilarProductSearchRequestMeta
    {
        public ISimilarityMeasures SimilarityMeasures { get; set;}
    }
}
