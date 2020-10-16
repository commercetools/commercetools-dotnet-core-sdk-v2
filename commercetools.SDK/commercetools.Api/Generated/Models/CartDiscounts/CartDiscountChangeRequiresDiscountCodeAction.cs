using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeRequiresDiscountCode")]
    public partial class CartDiscountChangeRequiresDiscountCodeAction : CartDiscountUpdateAction
    {
        public bool RequiresDiscountCode { get; set;}
        public CartDiscountChangeRequiresDiscountCodeAction()
        { 
           this.Action = "changeRequiresDiscountCode";
        }
    }
}
