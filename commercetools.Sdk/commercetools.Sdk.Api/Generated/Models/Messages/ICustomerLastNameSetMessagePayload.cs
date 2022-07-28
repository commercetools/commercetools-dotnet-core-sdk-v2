using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerLastNameSetMessagePayload))]
    public partial interface ICustomerLastNameSetMessagePayload : IMessagePayload
    {
        string LastName { get; set; }

    }
}
