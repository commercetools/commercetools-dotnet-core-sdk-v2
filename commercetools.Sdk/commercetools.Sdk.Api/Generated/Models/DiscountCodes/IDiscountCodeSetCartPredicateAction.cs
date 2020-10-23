using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    public interface IDiscountCodeSetCartPredicateAction : IDiscountCodeUpdateAction
    {
        string CartPredicate { get; set;}
    }
}
