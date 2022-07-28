using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction))]
    public partial interface IStagedOrderImportLineItemStateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        List<IItemState> State { get; set; }

    }
}
