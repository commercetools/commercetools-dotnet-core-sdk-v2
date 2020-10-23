using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public  partial class CartDiscountChangeRequiresDiscountCodeAction : ICartDiscountChangeRequiresDiscountCodeAction
    {
        public string Action { get; set;}
        
        public bool RequiresDiscountCode { get; set;}
        public CartDiscountChangeRequiresDiscountCodeAction()
        { 
           this.Action = "changeRequiresDiscountCode";
        }
    }
}
