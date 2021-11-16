using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeTaxCalculationModeAction))]
    public partial interface ICartChangeTaxCalculationModeAction : ICartUpdateAction
    {
        ITaxCalculationMode TaxCalculationMode { get; set;}
    }
}
