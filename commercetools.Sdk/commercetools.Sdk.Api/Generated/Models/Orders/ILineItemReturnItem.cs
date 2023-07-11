using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.LineItemReturnItem))]
    public partial interface ILineItemReturnItem : IReturnItem
    {
        string LineItemId { get; set; }

        new long Quantity { get; set; }

    }
}
