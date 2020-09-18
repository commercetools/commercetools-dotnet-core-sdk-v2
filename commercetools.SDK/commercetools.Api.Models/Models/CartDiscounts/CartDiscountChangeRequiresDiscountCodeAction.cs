using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeRequiresDiscountCode")]
    public class CartDiscountChangeRequiresDiscountCodeAction : CartDiscountUpdateAction
    {
        public bool RequiresDiscountCode { get; set;}
    }
}
