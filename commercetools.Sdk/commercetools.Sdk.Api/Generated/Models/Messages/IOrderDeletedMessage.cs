using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDeletedMessage))]
    public partial interface IOrderDeletedMessage : IOrderMessage
    {
        IOrder Order { get; set; }

    }
}
