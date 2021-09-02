using commercetools.MLApi.Models.Common;
using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProduct))]
    public partial interface ISimilarProduct
    {
        IProductReference Product { get; set; }

        long? VariantId { get; set; }

        ISimilarProductMeta Meta { get; set; }
    }
}
