using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingAddressAction))]
    public partial interface ICartSetShippingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
