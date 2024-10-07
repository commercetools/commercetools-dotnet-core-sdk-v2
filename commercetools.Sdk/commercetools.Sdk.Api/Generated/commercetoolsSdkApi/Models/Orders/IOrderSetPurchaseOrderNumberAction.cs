using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction))]
    public partial interface IOrderSetPurchaseOrderNumberAction : IOrderUpdateAction
    {
        string PurchaseOrderNumber { get; set; }

    }
}
