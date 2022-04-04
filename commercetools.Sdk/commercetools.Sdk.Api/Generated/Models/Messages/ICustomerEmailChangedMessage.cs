using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessage))]
    public partial interface ICustomerEmailChangedMessage : IMessage
    {
        string Email { get; set; }
    }
}
