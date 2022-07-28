using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditSetStagedActionsAction : IOrderEditUpdateAction
    {
        List<IStagedOrderUpdateAction> StagedActions { get; set; }

    }
}
