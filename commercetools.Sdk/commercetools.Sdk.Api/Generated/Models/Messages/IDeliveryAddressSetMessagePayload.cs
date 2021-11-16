using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryAddressSetMessagePayload))]
    public partial interface IDeliveryAddressSetMessagePayload : IMessagePayload
    {
        string DeliveryId { get; set; }

        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
