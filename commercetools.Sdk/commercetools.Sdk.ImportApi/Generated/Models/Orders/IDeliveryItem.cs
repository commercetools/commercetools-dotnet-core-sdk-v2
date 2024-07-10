using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.DeliveryItem))]
    public partial interface IDeliveryItem
    {
        string Id { get; set; }

        long Quantity { get; set; }

    }
}
