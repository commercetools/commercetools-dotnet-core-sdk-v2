using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingInfoSetMessage))]
    public partial interface IOrderShippingInfoSetMessage : IMessage
    {
        IShippingInfo ShippingInfo { get; set;}
        
        IShippingInfo OldShippingInfo { get; set;}
    }
}
