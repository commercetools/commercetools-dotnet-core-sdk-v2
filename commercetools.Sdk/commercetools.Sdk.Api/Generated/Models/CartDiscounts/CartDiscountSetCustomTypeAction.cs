using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
