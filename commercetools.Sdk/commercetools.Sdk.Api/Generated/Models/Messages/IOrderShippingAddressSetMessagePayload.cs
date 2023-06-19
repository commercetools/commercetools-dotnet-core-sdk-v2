using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessagePayload))]
    public partial interface IOrderShippingAddressSetMessagePayload : IOrderMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }

    }
}
