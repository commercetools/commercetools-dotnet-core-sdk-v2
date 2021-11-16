using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetDeliveryAddressCustomTypeAction : ICartSetDeliveryAddressCustomTypeAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public CartSetDeliveryAddressCustomTypeAction()
        { 
           this.Action = "setDeliveryAddressCustomType";
        }
    }
}
