using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerLastNameSetMessage))]
    public partial interface ICustomerLastNameSetMessage : IMessage
    {
        string LastName { get; set; }
    }
}
