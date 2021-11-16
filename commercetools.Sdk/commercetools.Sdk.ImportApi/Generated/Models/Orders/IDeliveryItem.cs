using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.DeliveryItem))]
    public partial interface IDeliveryItem 
    {
        string Id { get; set;}
        
        double Quantity { get; set;}
    }
}
