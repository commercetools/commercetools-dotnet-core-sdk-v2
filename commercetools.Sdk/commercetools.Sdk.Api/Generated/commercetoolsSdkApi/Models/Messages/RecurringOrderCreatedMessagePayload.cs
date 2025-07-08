using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderCreatedMessagePayload : IRecurringOrderCreatedMessagePayload
    {
        public string Type { get; set; }

        public IRecurringOrder Order { get; set; }
        public RecurringOrderCreatedMessagePayload()
        {
            this.Type = "RecurringOrderCreated";
        }
    }
}
