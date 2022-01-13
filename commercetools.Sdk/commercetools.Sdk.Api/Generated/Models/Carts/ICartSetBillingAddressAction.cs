using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetBillingAddressAction))]
    public partial interface ICartSetBillingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
