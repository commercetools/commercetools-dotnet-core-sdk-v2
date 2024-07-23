using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomTypeRemovedMessagePayload))]
    public partial interface IBusinessUnitAddressCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string OldTypeId { get; set; }

        string AddressId { get; set; }

    }
}
