using System;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetDeliveryAddressCustomFieldAction : ICartSetDeliveryAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartSetDeliveryAddressCustomFieldAction()
        { 
           this.Action = "setDeliveryAddressCustomField";
        }
    }
}
