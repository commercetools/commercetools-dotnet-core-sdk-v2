

namespace commercetools.Sdk.CheckoutApi.Models.Common
{

    public partial class PaymentMethodReference : IPaymentMethodReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public PaymentMethodReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment-method");
        }
    }
}
