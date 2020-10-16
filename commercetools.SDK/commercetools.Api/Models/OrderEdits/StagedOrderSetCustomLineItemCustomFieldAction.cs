using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomLineItemCustomField")]
    public partial class StagedOrderSetCustomLineItemCustomFieldAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetCustomLineItemCustomFieldAction()
        { 
           this.Action = "setCustomLineItemCustomField";
        }
    }
}
