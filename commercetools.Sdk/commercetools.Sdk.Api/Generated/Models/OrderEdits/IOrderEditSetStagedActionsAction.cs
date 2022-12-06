using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditSetStagedActionsAction : IOrderEditUpdateAction
    {
        IList<IStagedOrderUpdateAction> StagedActions { get; set; }
        IEnumerable<IStagedOrderUpdateAction> StagedActionsEnumerable { set => StagedActions = value.ToList(); }


    }
}
