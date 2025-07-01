using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangePriceRoundingModeAction))]
    public partial interface ICartChangePriceRoundingModeAction : ICartUpdateAction
    {
        IRoundingMode PriceRoundingMode { get; set; }

    }
}
