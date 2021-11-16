using System;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetBillingAddressCustomFieldAction : IOrderSetBillingAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetBillingAddressCustomFieldAction()
        { 
           this.Action = "setBillingAddressCustomField";
        }
    }
}
