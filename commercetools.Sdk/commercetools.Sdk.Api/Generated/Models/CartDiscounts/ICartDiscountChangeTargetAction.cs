using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    public partial interface ICartDiscountChangeTargetAction : ICartDiscountUpdateAction
    {
        ICartDiscountTarget Target { get; set;}
    }
}
