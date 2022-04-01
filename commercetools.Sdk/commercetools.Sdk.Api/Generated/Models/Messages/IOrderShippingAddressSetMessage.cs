using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingAddressSetMessage))]
    public partial interface IOrderShippingAddressSetMessage : IOrderMessage
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
