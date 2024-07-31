using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressCustomTypeRemovedMessage))]
    public partial interface ICustomerAddressCustomTypeRemovedMessage : IMessage
    {
        string PreviousTypeId { get; set; }

        string AddressId { get; set; }

    }
}
