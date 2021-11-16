using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerDeletedMessagePayload))]
    public partial interface ICustomerDeletedMessagePayload : IMessagePayload
    {
    }
}
