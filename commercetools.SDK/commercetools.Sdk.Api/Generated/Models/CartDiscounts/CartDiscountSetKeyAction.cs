using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setKey")]
    public partial class CartDiscountSetKeyAction : CartDiscountUpdateAction
    {
        public string Key { get; set;}
        public CartDiscountSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
