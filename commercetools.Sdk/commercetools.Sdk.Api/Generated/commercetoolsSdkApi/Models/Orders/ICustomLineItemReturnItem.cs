using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.CustomLineItemReturnItem))]
    public partial interface ICustomLineItemReturnItem : IReturnItem
    {
        new string Key { get; set; }

        string CustomLineItemId { get; set; }

        new long Quantity { get; set; }

    }
}
