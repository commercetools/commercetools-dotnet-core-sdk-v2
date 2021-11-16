using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddItemShippingAddressAction))]
    public partial interface ICartAddItemShippingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
