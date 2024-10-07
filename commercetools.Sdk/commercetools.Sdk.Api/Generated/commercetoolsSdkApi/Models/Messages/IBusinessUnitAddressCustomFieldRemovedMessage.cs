using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessage))]
    public partial interface IBusinessUnitAddressCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

        string AddressId { get; set; }

    }
}
