using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDeletedMessage))]
    public partial interface IOrderDeletedMessage : IOrderMessage
    {
        IOrder Order { get; set; }
    }
}
