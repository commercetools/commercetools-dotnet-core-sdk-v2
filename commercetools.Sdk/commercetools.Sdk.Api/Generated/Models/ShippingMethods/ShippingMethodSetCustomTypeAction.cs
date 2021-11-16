using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetCustomTypeAction : IShippingMethodSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public ShippingMethodSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
