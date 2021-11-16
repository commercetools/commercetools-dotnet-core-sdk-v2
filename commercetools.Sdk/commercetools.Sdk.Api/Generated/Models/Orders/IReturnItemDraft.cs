using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ReturnItemDraft))]
    public partial interface IReturnItemDraft 
    {
        long Quantity { get; set;}
        
        string LineItemId { get; set;}
        
        string CustomLineItemId { get; set;}
        
        string Comment { get; set;}
        
        IReturnShipmentState ShipmentState { get; set;}
    }
}
