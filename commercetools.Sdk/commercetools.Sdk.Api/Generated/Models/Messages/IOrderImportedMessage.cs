using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderImportedMessage))]
    public partial interface IOrderImportedMessage : IMessage
    {
        IOrder Order { get; set; }
    }
}
