using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public  partial class CartDiscountChangeIsActiveAction : ICartDiscountChangeIsActiveAction
    {
        public string Action { get; set;}
        
        public bool IsActive { get; set;}
        public CartDiscountChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
