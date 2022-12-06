using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction))]
    public partial interface IOrderImportCustomLineItemStateAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


    }
}
