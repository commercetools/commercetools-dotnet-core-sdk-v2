using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomField")]
    public partial class StagedOrderSetCustomFieldAction : StagedOrderUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
