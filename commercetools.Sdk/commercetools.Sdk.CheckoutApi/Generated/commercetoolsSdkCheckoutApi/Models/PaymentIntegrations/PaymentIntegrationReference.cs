using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class PaymentIntegrationReference : IPaymentIntegrationReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public PaymentIntegrationReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment-integration");
        }
    }
}
