using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeTaxModeAction))]
    public partial interface ICartChangeTaxModeAction : ICartUpdateAction
    {
        ITaxMode TaxMode { get; set;}
    }
}
