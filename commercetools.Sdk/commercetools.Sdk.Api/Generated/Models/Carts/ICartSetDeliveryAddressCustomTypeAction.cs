using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDeliveryAddressCustomTypeAction))]
    public partial interface ICartSetDeliveryAddressCustomTypeAction : ICartUpdateAction
    {
        string DeliveryId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
