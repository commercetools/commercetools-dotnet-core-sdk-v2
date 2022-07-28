using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessage))]
    public partial interface ICustomerLastNameSetMessage : IMessage
    {
        string LastName { get; set; }

    }
}
