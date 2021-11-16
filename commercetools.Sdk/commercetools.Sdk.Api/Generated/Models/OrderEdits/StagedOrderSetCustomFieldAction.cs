using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomFieldAction : IStagedOrderSetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public StagedOrderSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
