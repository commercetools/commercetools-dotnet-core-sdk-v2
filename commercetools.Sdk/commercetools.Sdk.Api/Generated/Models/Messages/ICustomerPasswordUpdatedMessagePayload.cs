using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload))]
    public partial interface ICustomerPasswordUpdatedMessagePayload : IMessagePayload
    {
        bool Reset { get; set; }

    }
}
