using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomFieldRemovedMessagePayload))]
    public partial interface ICustomerAddressCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

        string AddressId { get; set; }

    }
}
