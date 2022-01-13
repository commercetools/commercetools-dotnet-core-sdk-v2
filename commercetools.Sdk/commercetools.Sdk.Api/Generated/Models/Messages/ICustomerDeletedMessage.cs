using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerDeletedMessage))]
    public partial interface ICustomerDeletedMessage : IMessage
    {
    }
}
