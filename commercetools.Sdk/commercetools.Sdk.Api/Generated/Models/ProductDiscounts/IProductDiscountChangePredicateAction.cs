using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction))]
    public partial interface IProductDiscountChangePredicateAction : IProductDiscountUpdateAction
    {
        string Predicate { get; set; }
    }
}
