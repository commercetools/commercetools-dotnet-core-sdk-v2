

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetRefundPolicyUrlAction : IStoreSetRefundPolicyUrlAction
    {
        public string Action { get; set; }

        public string RefundPolicyUrl { get; set; }
        public StoreSetRefundPolicyUrlAction()
        {
            this.Action = "setRefundPolicyUrl";
        }
    }
}
