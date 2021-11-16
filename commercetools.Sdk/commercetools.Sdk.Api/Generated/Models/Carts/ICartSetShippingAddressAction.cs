using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetShippingAddressAction))]
    public partial interface ICartSetShippingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
