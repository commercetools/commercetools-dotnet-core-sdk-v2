using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("absolute")]
    public class CartDiscountValueAbsoluteDraft : CartDiscountValueDraft
    {
        public List<Money> Money { get; set;}
    }
}
