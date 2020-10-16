using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setOrderNumber")]
    public partial class StagedOrderSetOrderNumberAction : StagedOrderUpdateAction
    {
        public string OrderNumber { get; set;}
        public StagedOrderSetOrderNumberAction()
        { 
           this.Action = "setOrderNumber";
        }
    }
}
