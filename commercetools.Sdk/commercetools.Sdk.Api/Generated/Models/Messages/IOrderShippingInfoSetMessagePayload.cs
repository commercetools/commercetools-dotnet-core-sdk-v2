using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    public partial interface IOrderShippingInfoSetMessagePayload : IMessagePayload
    {
        IShippingInfo ShippingInfo { get; set;}
        
        IShippingInfo OldShippingInfo { get; set;}
    }
}
