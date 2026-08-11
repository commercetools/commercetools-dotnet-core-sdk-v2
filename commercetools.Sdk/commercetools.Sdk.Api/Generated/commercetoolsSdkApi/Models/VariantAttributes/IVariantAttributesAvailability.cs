using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributesAvailability))]
    public partial interface IVariantAttributesAvailability
    {
        bool? IsOnStock { get; set; }

        long? AvailableQuantity { get; set; }

        IVariantAttributesChannelAvailabilityMap Channels { get; set; }

    }
}
