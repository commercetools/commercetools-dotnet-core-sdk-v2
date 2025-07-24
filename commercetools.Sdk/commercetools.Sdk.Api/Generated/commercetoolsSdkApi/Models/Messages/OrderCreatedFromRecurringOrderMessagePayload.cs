using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCreatedFromRecurringOrderMessagePayload : IOrderCreatedFromRecurringOrderMessagePayload
    {
        public string Type { get; set; }

        public IOrder Order { get; set; }

        public IRecurringOrderReference RecurringOrderRef { get; set; }
        public OrderCreatedFromRecurringOrderMessagePayload()
        {
            this.Type = "OrderCreatedFromRecurringOrder";
        }
    }
}
