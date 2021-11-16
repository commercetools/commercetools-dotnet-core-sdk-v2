using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    public partial interface ICartDiscountValueAbsolute : ICartDiscountValue
    {
        List<ITypedMoney> Money { get; set;}
    }
}
