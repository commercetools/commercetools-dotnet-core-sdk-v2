using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessagePayload))]
    public partial interface ICustomerAddressCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string PreviousTypeId { get; set; }

        string AddressId { get; set; }

    }
}
