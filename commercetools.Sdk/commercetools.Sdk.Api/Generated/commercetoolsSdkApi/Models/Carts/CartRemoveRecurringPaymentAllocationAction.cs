

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartRemoveRecurringPaymentAllocationAction : ICartRemoveRecurringPaymentAllocationAction
    {
        public string Action { get; set; }

        public string Id { get; set; }
        public CartRemoveRecurringPaymentAllocationAction()
        {
            this.Action = "removeRecurringPaymentAllocation";
        }
    }
}
