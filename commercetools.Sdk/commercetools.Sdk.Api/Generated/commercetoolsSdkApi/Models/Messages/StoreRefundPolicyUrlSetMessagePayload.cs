

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreRefundPolicyUrlSetMessagePayload : IStoreRefundPolicyUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string RefundPolicyUrl { get; set; }
        public StoreRefundPolicyUrlSetMessagePayload()
        {
            this.Type = "StoreRefundPolicyUrlSet";
        }
    }
}
