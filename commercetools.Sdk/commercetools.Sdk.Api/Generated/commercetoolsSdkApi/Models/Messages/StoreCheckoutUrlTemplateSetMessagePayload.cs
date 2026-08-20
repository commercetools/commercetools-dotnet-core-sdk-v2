

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCheckoutUrlTemplateSetMessagePayload : IStoreCheckoutUrlTemplateSetMessagePayload
    {
        public string Type { get; set; }

        public string CheckoutUrlTemplate { get; set; }
        public StoreCheckoutUrlTemplateSetMessagePayload()
        {
            this.Type = "StoreCheckoutUrlTemplateSet";
        }
    }
}
