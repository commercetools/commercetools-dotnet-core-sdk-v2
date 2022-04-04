using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderMessagePayload))]
    public partial interface IOrderMessagePayload : IMessagePayload
    {
    }
}
