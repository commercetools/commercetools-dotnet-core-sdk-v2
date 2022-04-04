using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction))]
    public partial interface IStagedOrderImportCustomLineItemStateAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        List<IItemState> State { get; set; }
    }
}
