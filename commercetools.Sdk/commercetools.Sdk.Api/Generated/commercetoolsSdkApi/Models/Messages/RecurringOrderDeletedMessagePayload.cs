using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderDeletedMessagePayload : IRecurringOrderDeletedMessagePayload
    {
        public string Type { get; set; }

        public IRecurringOrder RecurringOrder { get; set; }
        public RecurringOrderDeletedMessagePayload()
        {
            this.Type = "RecurringOrderDeleted";
        }
    }
}
