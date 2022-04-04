using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    public partial interface IOrderShippingInfoSetMessagePayload : IOrderMessagePayload
    {
        IShippingInfo ShippingInfo { get; set; }

        IShippingInfo OldShippingInfo { get; set; }
    }
}
