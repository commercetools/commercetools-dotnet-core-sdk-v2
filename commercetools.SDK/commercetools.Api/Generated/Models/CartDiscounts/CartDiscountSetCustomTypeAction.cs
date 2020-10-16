using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setCustomType")]
    public partial class CartDiscountSetCustomTypeAction : CartDiscountUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public CartDiscountSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
