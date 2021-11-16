using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerEmailChangedMessage))]
    public partial interface ICustomerEmailChangedMessage : IMessage
    {
        string Email { get; set;}
    }
}
