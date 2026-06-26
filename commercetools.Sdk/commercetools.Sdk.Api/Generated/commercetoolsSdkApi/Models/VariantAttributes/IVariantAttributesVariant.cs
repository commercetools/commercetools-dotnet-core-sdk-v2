using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributesVariant))]
    public partial interface IVariantAttributesVariant
    {
        string Id { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

        IVariantAttributesAvailability Availability { get; set; }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
