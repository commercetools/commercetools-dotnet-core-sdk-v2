using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemCustomTypeAction : IMyCartSetLineItemCustomTypeAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public MyCartSetLineItemCustomTypeAction()
        { 
           this.Action = "setLineItemCustomType";
        }
    }
}
