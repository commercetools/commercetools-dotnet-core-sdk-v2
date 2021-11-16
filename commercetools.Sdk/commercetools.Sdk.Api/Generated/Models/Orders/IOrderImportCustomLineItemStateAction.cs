using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderImportCustomLineItemStateAction))]
    public partial interface IOrderImportCustomLineItemStateAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        List<IItemState> State { get; set;}
    }
}
