using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemCustomField")]
    public partial class StagedOrderSetLineItemCustomFieldAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetLineItemCustomFieldAction()
        { 
           this.Action = "setLineItemCustomField";
        }
    }
}
