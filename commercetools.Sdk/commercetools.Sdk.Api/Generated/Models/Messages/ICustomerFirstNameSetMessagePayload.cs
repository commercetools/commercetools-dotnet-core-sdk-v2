using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerFirstNameSetMessagePayload))]
    public partial interface ICustomerFirstNameSetMessagePayload : IMessagePayload
    {
        string FirstName { get; set;}
    }
}
