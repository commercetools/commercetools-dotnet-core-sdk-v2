using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderReference : IRecurringOrderReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IRecurringOrder Obj { get; set; }
        public RecurringOrderReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurring-order");
        }
    }
}
