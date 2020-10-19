using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setCustomField")]
    public partial class CartDiscountSetCustomFieldAction : CartDiscountUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartDiscountSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
