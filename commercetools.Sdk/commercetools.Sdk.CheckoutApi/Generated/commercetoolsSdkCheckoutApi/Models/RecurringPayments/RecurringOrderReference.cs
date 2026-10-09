using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringOrderReference : IRecurringOrderReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public RecurringOrderReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurring-order");
        }
    }
}
