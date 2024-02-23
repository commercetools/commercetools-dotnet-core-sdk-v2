using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressChangedMessagePayload))]
    public partial interface ICustomerAddressChangedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
