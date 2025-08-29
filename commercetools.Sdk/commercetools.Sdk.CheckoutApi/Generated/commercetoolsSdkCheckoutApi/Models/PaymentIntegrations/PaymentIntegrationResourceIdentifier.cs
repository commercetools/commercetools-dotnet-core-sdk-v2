using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class PaymentIntegrationResourceIdentifier : IPaymentIntegrationResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public PaymentIntegrationResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment-integration");
        }
    }
}
