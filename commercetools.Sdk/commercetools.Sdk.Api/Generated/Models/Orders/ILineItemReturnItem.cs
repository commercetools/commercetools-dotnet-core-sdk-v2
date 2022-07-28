using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.LineItemReturnItem))]
    public partial interface ILineItemReturnItem : IReturnItem
    {
        string LineItemId { get; set; }

    }
}
