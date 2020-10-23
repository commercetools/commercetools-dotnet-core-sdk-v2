using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public  partial class CartDiscountChangeTargetAction : ICartDiscountChangeTargetAction
    {
        public string Action { get; set;}
        
        public ICartDiscountTarget Target { get; set;}
        public CartDiscountChangeTargetAction()
        { 
           this.Action = "changeTarget";
        }
    }
}
