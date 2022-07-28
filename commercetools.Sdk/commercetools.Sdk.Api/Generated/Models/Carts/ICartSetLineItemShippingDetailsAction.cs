using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemShippingDetailsAction))]
    public partial interface ICartSetLineItemShippingDetailsAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
