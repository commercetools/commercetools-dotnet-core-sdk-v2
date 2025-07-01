using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodReference : IPaymentMethodReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IPaymentMethod Obj { get; set; }
        public PaymentMethodReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment-method");
        }
    }
}
