using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setStagedActions")]
    public partial class OrderEditSetStagedActionsAction : OrderEditUpdateAction
    {
        public List<StagedOrderUpdateAction> StagedActions { get; set;}
        public OrderEditSetStagedActionsAction()
        { 
           this.Action = "setStagedActions";
        }
    }
}
