using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    public partial interface ICartDiscountChangeCartPredicateAction : ICartDiscountUpdateAction
    {
        string CartPredicate { get; set; }
    }
}
