using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerFirstNameSetMessage))]
    public partial interface ICustomerFirstNameSetMessage : IMessage
    {
        string FirstName { get; set;}
    }
}
