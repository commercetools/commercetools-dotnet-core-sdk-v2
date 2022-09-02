using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingCustomTypeAction))]
    public partial interface ICartSetShippingCustomTypeAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
