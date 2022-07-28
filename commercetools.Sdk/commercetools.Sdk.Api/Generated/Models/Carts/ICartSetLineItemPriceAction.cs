using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemPriceAction))]
    public partial interface ICartSetLineItemPriceAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IMoney ExternalPrice { get; set; }

    }
}
