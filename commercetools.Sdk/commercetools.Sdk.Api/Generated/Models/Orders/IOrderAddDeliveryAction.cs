using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddDeliveryAction))]
    public partial interface IOrderAddDeliveryAction : IOrderUpdateAction
    {
        List<IDeliveryItem> Items { get; set;}
        
        IBaseAddress Address { get; set;}
        
        List<IParcelDraft> Parcels { get; set;}
    }
}
