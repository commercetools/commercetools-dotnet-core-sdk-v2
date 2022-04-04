using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetItemShippingAddressCustomTypeAction))]
    public partial interface ICartSetItemShippingAddressCustomTypeAction : ICartUpdateAction
    {
        string AddressKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
