using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeTaxRoundingModeAction))]
    public partial interface ICartChangeTaxRoundingModeAction : ICartUpdateAction
    {
        IRoundingMode TaxRoundingMode { get; set; }
    }
}
