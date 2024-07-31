using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction))]
    public partial interface ICartSetLineItemTotalPriceAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

    }
}
