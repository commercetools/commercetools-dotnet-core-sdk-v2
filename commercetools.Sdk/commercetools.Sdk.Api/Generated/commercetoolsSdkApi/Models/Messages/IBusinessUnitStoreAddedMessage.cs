using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoreAddedMessage))]
    public partial interface IBusinessUnitStoreAddedMessage : IMessage
    {
        IStoreKeyReference Store { get; set; }

    }
}
