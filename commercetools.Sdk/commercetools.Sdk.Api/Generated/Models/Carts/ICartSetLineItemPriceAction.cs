using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetLineItemPriceAction))]
    public partial interface ICartSetLineItemPriceAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IMoney ExternalPrice { get; set; }
    }
}
