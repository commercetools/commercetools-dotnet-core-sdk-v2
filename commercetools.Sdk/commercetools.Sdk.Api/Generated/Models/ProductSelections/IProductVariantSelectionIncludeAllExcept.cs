using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept))]
    public partial interface IProductVariantSelectionIncludeAllExcept : IProductVariantSelection
    {
        new IProductVariantSelectionTypeEnum Type { get; set; }

        IList<string> Skus { get; set; }
        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }


    }
}
