using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerFirstNameSetMessagePayload))]
    public partial interface ICustomerFirstNameSetMessagePayload : IMessagePayload
    {
        string FirstName { get; set; }

    }
}
