using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerEmailVerifiedMessage))]
    public partial interface ICustomerEmailVerifiedMessage : IMessage
    {
    }
}
