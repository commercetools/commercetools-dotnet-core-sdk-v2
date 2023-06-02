using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction))]
    public partial interface IStagedOrderSetShippingMethodTaxAmountAction : IStagedOrderUpdateAction
    {
        string ShippingKey { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

    }
}
