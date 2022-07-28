using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction))]
    public partial interface IStagedOrderChangeTaxCalculationModeAction : IStagedOrderUpdateAction
    {
        ITaxCalculationMode TaxCalculationMode { get; set; }

    }
}
