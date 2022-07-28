using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.SimilarProducts.ProductSetSelector))]
    public partial interface IProductSetSelector
    {
        string ProjectKey { get; set; }

        List<string> ProductIds { get; set; }

        List<string> ProductTypeIds { get; set; }

        bool? Staged { get; set; }

        bool? IncludeVariants { get; set; }

        long? ProductSetLimit { get; set; }

    }
}
