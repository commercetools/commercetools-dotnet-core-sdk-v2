using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddRecurringPaymentAllocationAction : ICartAddRecurringPaymentAllocationAction
    {
        public string Action { get; set; }

        public string Id { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IAllocationDraft Allocation { get; set; }
        public CartAddRecurringPaymentAllocationAction()
        {
            this.Action = "addRecurringPaymentAllocation";
        }
    }
}
