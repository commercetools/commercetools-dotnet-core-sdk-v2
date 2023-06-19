using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerAddressAddedMessagePayload))]
    public partial interface ICustomerAddressAddedMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

    }
}
