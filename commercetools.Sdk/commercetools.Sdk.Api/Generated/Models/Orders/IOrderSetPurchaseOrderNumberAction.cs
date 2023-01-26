using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetPurchaseOrderNumberAction))]
    public partial interface IOrderSetPurchaseOrderNumberAction : IOrderUpdateAction
    {
        string PurchaseOrderNumber { get; set; }

    }
}
