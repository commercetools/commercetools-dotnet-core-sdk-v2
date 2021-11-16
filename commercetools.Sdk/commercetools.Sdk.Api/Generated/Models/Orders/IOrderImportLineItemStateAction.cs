using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderImportLineItemStateAction))]
    public partial interface IOrderImportLineItemStateAction : IOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        List<IItemState> State { get; set;}
    }
}
