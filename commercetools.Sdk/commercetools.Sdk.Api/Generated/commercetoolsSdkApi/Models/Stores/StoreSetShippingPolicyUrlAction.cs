

namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetShippingPolicyUrlAction : IStoreSetShippingPolicyUrlAction
    {
        public string Action { get; set; }

        public string ShippingPolicyUrl { get; set; }
        public StoreSetShippingPolicyUrlAction()
        {
            this.Action = "setShippingPolicyUrl";
        }
    }
}
