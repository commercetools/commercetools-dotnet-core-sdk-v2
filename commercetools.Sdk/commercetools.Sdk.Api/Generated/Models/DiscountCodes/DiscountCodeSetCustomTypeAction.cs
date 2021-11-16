using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetCustomTypeAction : IDiscountCodeSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public DiscountCodeSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
