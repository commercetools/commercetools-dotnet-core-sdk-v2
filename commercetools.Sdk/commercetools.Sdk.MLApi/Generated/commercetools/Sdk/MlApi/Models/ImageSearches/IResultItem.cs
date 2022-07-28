using commercetools.Sdk.MLApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearches.ResultItem))]
    public partial interface IResultItem
    {
        string ImageUrl { get; set; }

        List<IProductVariant> ProductVariants { get; set; }

    }
}
