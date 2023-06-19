using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion))]
    public partial interface IProductVariantSelectionInclusion : IProductVariantSelection
    {
        new IProductVariantSelectionTypeEnum Type { get; set; }

        IList<string> Skus { get; set; }
        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }


    }
}
