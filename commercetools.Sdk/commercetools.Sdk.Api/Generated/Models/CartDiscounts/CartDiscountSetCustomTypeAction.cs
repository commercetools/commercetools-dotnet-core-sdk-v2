using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetCustomTypeAction : ICartDiscountSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public CartDiscountSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
