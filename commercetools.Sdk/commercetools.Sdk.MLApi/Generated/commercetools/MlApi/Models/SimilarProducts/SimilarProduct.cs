using commercetools.MLApi.Models.Common;
using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProduct : ISimilarProduct
    {
        public IProductReference Product { get; set; }

        public long? VariantId { get; set; }

        public ISimilarProductMeta Meta { get; set; }
    }
}
