using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion))]
    public partial interface IProductVariantSelectionExclusion : IProductVariantSelection
    {
        new IProductVariantSelectionTypeEnum Type { get; set; }

        List<string> Skus { get; set; }
    }
}
