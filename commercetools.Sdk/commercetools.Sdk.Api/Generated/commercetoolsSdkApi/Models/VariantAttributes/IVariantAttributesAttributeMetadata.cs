using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributesAttributeMetadata))]
    public partial interface IVariantAttributesAttributeMetadata
    {
        string Name { get; set; }

        ILocalizedString Label { get; set; }

        string Type { get; set; }

    }
}
