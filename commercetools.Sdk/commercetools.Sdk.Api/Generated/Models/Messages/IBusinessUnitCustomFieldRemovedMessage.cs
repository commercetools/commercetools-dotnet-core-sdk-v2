using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldRemovedMessage))]
    public partial interface IBusinessUnitCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
