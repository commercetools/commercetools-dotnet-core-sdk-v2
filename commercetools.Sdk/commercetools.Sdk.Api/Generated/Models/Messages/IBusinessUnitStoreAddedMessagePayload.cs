using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessagePayload))]
    public partial interface IBusinessUnitStoreAddedMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

    }
}
