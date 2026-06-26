

namespace commercetools.Sdk.Api.Models.VariantAttributes
{

    public partial class VariantAttributesAvailability : IVariantAttributesAvailability
    {
        public bool? IsOnStock { get; set; }

        public long? AvailableQuantity { get; set; }

        public IVariantAttributesChannelAvailabilityMap Channels { get; set; }
    }
}
