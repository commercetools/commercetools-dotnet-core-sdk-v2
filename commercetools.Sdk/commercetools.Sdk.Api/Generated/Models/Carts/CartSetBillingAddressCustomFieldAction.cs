using System;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetBillingAddressCustomFieldAction : ICartSetBillingAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartSetBillingAddressCustomFieldAction()
        { 
           this.Action = "setBillingAddressCustomField";
        }
    }
}
