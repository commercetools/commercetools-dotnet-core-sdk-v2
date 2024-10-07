using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldRemovedMessagePayload))]
    public partial interface IBusinessUnitAddressCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

        string AddressId { get; set; }

    }
}
