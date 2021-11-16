using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemCustomFieldAction : IStagedOrderSetCustomLineItemCustomFieldAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetCustomLineItemCustomFieldAction()
        { 
           this.Action = "setCustomLineItemCustomField";
        }
    }
}
