using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingAddressSetMessage))]
    public partial interface IOrderShippingAddressSetMessage : IOrderMessage
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
