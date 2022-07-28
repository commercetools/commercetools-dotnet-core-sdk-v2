using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessage))]
    public partial interface ICustomerFirstNameSetMessage : IMessage
    {
        string FirstName { get; set; }

    }
}
