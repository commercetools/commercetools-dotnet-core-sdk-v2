using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentResourceIdentifier : IPaymentResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public PaymentResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment");
        }
    }
}
