using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.CustomLineItemReturnItem))]
    public partial interface ICustomLineItemReturnItem : IReturnItem
    {
        string CustomLineItemId { get; set; }

    }
}
