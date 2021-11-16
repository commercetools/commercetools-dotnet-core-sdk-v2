using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerLastNameSetMessagePayload))]
    public partial interface ICustomerLastNameSetMessagePayload : IMessagePayload
    {
        string LastName { get; set;}
    }
}
