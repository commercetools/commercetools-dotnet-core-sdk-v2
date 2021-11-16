using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetValidFromAndUntilAction : ICartDiscountSetValidFromAndUntilAction
    {
        public string Action { get; set;}
        
        public DateTime? ValidFrom { get; set;}
        
        public DateTime? ValidUntil { get; set;}
        public CartDiscountSetValidFromAndUntilAction()
        { 
           this.Action = "setValidFromAndUntil";
        }
    }
}
