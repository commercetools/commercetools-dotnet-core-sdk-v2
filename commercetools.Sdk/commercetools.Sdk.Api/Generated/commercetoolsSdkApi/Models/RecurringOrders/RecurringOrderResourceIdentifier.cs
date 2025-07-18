using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderResourceIdentifier : IRecurringOrderResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public RecurringOrderResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurring-order");
        }
    }
}
