using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeTaxModeAction))]
    public partial interface ICartChangeTaxModeAction : ICartUpdateAction
    {
        ITaxMode TaxMode { get; set; }

    }
}
