using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction))]
    public partial interface IStagedOrderChangeTaxModeAction : IStagedOrderUpdateAction
    {
        ITaxMode TaxMode { get; set;}
    }
}
