using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Payments
{

    public partial class PaymentReference : IPaymentReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public PaymentReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment");
        }
    }
}
