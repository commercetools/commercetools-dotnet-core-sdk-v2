using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addStagedAction")]
    public partial class OrderEditAddStagedActionAction : OrderEditUpdateAction
    {
        public StagedOrderUpdateAction StagedAction { get; set;}
        public OrderEditAddStagedActionAction()
        { 
           this.Action = "addStagedAction";
        }
    }
}
