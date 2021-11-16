using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction))]
    public partial interface IStagedOrderImportLineItemStateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        List<IItemState> State { get; set; }
    }
}
