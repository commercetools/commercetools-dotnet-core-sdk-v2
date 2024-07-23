using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingRateInputAction))]
    public partial interface ICartSetShippingRateInputAction : ICartUpdateAction
    {
        IShippingRateInputDraft ShippingRateInput { get; set; }

    }
}
