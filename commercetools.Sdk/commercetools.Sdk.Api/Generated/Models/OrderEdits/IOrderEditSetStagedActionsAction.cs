using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetStagedActionsAction))]
    public partial interface IOrderEditSetStagedActionsAction : IOrderEditUpdateAction
    {
        List<IStagedOrderUpdateAction> StagedActions { get; set;}
    }
}
