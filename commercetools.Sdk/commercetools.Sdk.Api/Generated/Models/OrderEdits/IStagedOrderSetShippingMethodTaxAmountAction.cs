using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction))]
    public partial interface IStagedOrderSetShippingMethodTaxAmountAction : IStagedOrderUpdateAction
    {
        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
    }
}
