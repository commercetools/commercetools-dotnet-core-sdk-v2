using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAttributesAction))]
    public partial interface IVariantSetAttributesAction : IVariantUpdateAction
    {
        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        bool? Staged { get; set; }

    }
}
