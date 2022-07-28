using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxRoundingModeAction))]
    public partial interface ICartChangeTaxRoundingModeAction : ICartUpdateAction
    {
        IRoundingMode TaxRoundingMode { get; set; }

    }
}
