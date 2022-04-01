using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxCalculationModeAction))]
    public partial interface ICartChangeTaxCalculationModeAction : ICartUpdateAction
    {
        ITaxCalculationMode TaxCalculationMode { get; set; }
    }
}
