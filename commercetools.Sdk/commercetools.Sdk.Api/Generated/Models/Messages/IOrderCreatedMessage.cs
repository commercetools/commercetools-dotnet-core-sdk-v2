using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCreatedMessage))]
    public partial interface IOrderCreatedMessage : IMessage
    {
        IOrder Order { get; set; }
    }
}
