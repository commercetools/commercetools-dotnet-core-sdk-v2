using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCreatedMessagePayload))]
    public partial interface IOrderCreatedMessagePayload : IMessagePayload
    {
        IOrder Order { get; set;}
    }
}
