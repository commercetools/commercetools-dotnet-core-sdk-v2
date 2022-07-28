using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerEmailChangedMessagePayload))]
    public partial interface ICustomerEmailChangedMessagePayload : IMessagePayload
    {
        string Email { get; set; }

    }
}
