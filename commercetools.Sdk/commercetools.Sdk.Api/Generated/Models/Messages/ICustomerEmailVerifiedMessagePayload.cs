using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerEmailVerifiedMessagePayload))]
    public partial interface ICustomerEmailVerifiedMessagePayload : IMessagePayload
    {
    }
}
