using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetParcelItemsAction))]
    public partial interface IOrderSetParcelItemsAction : IOrderUpdateAction
    {
        string ParcelId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
