using System;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomLineItemCustomFieldAction : IOrderSetCustomLineItemCustomFieldAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetCustomLineItemCustomFieldAction()
        { 
           this.Action = "setCustomLineItemCustomField";
        }
    }
}
