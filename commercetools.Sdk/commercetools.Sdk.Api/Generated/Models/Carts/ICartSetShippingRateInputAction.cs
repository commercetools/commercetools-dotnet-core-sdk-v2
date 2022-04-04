using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction))]
    public partial interface ICartSetShippingRateInputAction : ICartUpdateAction
    {
        IShippingRateInputDraft ShippingRateInput { get; set; }
    }
}
