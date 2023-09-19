using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessage))]
    public partial interface IBusinessUnitAddressCustomTypeRemovedMessage : IMessage
    {
        string OldTypeId { get; set; }

    }
}
