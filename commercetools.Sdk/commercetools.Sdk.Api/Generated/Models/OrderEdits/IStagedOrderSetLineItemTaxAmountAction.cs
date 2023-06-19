using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    public partial interface IStagedOrderSetLineItemTaxAmountAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

        string ShippingKey { get; set; }

    }
}
