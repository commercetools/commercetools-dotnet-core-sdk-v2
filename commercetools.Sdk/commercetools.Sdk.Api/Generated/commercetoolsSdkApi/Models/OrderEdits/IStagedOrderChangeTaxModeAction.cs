using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction))]
    public partial interface IStagedOrderChangeTaxModeAction : IStagedOrderUpdateAction
    {
        ITaxMode TaxMode { get; set; }

    }
}
