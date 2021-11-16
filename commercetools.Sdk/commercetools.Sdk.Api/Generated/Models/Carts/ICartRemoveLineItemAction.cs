using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveLineItemAction))]
    public partial interface ICartRemoveLineItemAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        long? Quantity { get; set;}
        
        IMoney ExternalPrice { get; set;}
        
        IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        IItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
    }
}
