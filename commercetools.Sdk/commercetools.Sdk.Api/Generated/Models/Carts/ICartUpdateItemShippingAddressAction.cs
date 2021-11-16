using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartUpdateItemShippingAddressAction))]
    public partial interface ICartUpdateItemShippingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
