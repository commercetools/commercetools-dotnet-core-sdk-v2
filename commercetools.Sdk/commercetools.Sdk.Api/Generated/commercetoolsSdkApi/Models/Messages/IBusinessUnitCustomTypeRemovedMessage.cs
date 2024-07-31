using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeRemovedMessage))]
    public partial interface IBusinessUnitCustomTypeRemovedMessage : IMessage
    {
        string OldTypeId { get; set; }

    }
}
