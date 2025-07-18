using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderStateChangedMessagePayload : IRecurringOrderStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IRecurringOrderState State { get; set; }

        public IRecurringOrderState OldState { get; set; }
        public RecurringOrderStateChangedMessagePayload()
        {
            this.Type = "RecurringOrderStateChanged";
        }
    }
}
