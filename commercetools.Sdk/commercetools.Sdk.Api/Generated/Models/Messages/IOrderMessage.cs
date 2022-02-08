using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderMessage))]
    public partial interface IOrderMessage : IMessage
    {
    }
}
