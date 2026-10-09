using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class RecurringPaymentAllocation : IRecurringPaymentAllocation
    {
        public string Id { get; set; }

        public IPaymentMethodReference PaymentMethod { get; set; }

        public IAllocation Allocation { get; set; }
    }
}
