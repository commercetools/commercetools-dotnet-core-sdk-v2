using System;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomFieldAction : IOrderSetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
