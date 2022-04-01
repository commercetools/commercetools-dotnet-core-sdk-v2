using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.DeliveryItem))]
    public partial interface IDeliveryItem
    {
        string Id { get; set; }

        long Quantity { get; set; }
    }
}
