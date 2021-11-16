using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction))]
    public partial interface IStagedOrderChangeTaxCalculationModeAction : IStagedOrderUpdateAction
    {
        ITaxCalculationMode TaxCalculationMode { get; set;}
    }
}
