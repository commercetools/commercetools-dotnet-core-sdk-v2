using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ReturnItemDraft))]
    public partial interface IReturnItemDraft 
    {
        double Quantity { get; set;}
        
        string LineItemId { get; set;}
        
        string CustomLineItemId { get; set;}
        
        string Comment { get; set;}
        
        IReturnShipmentState ShipmentState { get; set;}
    }
}
