using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributesChannelAvailability))]
    public partial interface IVariantAttributesChannelAvailability
    {
        bool? IsOnStock { get; set; }

        long? AvailableQuantity { get; set; }

    }
}
