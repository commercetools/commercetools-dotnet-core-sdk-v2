using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedFromRecurringOrderMessagePayload))]
    public partial interface IOrderCreatedFromRecurringOrderMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }

        IRecurringOrderReference RecurringOrderRef { get; set; }

    }
}
