using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction))]
    public partial interface ICartSetCustomLineItemShippingDetailsAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
