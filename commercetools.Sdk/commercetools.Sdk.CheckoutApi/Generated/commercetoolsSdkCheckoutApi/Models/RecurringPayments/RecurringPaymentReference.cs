using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentReference : IRecurringPaymentReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public RecurringPaymentReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurring-payment");
        }
    }
}
