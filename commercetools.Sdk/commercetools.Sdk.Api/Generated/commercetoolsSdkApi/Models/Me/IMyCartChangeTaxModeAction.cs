using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartChangeTaxModeAction))]
    public partial interface IMyCartChangeTaxModeAction : IMyCartUpdateAction
    {
        ITaxMode TaxMode { get; set; }

    }
}
