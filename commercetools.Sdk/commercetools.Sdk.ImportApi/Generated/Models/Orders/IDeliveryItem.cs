using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.DeliveryItem))]
    public partial interface IDeliveryItem
    {
        string Id { get; set; }

        decimal Quantity { get; set; }
    }
}
