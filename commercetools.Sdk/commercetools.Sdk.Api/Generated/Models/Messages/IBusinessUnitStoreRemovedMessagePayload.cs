using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreRemovedMessagePayload))]
    public partial interface IBusinessUnitStoreRemovedMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

    }
}
