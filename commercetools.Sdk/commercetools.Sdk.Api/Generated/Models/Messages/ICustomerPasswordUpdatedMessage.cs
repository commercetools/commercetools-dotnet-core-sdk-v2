using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerPasswordUpdatedMessage))]
    public partial interface ICustomerPasswordUpdatedMessage : IMessage
    {
        bool Reset { get; set;}
    }
}
