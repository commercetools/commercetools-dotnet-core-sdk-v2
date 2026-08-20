

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreShippingPolicyUrlSetMessagePayload : IStoreShippingPolicyUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string ShippingPolicyUrl { get; set; }
        public StoreShippingPolicyUrlSetMessagePayload()
        {
            this.Type = "StoreShippingPolicyUrlSet";
        }
    }
}
