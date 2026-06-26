using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributes))]
    public partial interface IVariantAttributes
    {
        string ProductId { get; set; }

        string ProductKey { get; set; }

        IList<IVariantAttributesAttributeMetadata> Attributes { get; set; }

        IEnumerable<IVariantAttributesAttributeMetadata> AttributesEnumerable { set => Attributes = value.ToList(); }

        IList<IVariantAttributesVariant> Variants { get; set; }

        IEnumerable<IVariantAttributesVariant> VariantsEnumerable { set => Variants = value.ToList(); }

    }
}
