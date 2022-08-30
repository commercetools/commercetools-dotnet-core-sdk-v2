using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddressSetMessagePayload))]
    public partial interface IDeliveryAddressSetMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }

        string ShippingKey { get; set; }

    }
}
