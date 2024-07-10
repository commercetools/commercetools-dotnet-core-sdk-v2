using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetPurchaseOrderNumberAction))]
    public partial interface IStagedOrderSetPurchaseOrderNumberAction : IStagedOrderUpdateAction
    {
        string PurchaseOrderNumber { get; set; }

    }
}
