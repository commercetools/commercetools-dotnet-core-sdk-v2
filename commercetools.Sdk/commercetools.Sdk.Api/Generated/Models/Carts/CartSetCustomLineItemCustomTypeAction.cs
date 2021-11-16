using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetCustomLineItemCustomTypeAction : ICartSetCustomLineItemCustomTypeAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public CartSetCustomLineItemCustomTypeAction()
        { 
           this.Action = "setCustomLineItemCustomType";
        }
    }
}
