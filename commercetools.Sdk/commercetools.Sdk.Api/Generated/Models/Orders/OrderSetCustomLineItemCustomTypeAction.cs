using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomLineItemCustomTypeAction : IOrderSetCustomLineItemCustomTypeAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public OrderSetCustomLineItemCustomTypeAction()
        { 
           this.Action = "setCustomLineItemCustomType";
        }
    }
}
