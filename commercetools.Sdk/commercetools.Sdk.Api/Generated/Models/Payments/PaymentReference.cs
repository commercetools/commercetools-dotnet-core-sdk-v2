using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentReference : IPaymentReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IPayment Obj { get; set; }
        public PaymentReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment");
        }
    }
}
