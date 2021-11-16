using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerPasswordUpdatedMessagePayload))]
    public partial interface ICustomerPasswordUpdatedMessagePayload : IMessagePayload
    {
        bool Reset { get; set;}
    }
}
