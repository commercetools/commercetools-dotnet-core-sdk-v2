using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetCustomFieldAction : IOrderEditSetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderEditSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
