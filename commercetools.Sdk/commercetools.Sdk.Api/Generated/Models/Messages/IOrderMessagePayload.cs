using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderMessagePayload))]
    public partial interface IOrderMessagePayload : IMessagePayload
    {
    }
}
