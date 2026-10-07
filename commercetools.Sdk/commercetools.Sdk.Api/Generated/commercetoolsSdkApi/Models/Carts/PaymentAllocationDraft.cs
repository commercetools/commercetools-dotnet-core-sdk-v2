using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class PaymentAllocationDraft : IPaymentAllocationDraft
    {
        public string Id { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IAllocationDraft Allocation { get; set; }
    }
}
