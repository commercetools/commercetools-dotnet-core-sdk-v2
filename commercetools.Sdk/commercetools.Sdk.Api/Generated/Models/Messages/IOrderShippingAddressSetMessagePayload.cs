using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingAddressSetMessagePayload))]
    public partial interface IOrderShippingAddressSetMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
