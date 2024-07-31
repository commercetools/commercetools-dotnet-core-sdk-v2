using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantExclusion))]
    public partial interface IProductVariantExclusion
    {
        IList<string> Skus { get; set; }

        IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

    }
}
