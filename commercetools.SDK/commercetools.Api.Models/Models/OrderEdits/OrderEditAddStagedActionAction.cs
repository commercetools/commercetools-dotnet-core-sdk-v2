using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addStagedAction")]
    public class OrderEditAddStagedActionAction : OrderEditUpdateAction
    {
        public StagedOrderUpdateAction StagedAction { get; set;}
    }
}
