using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setDescription")]
    public class CartDiscountSetDescriptionAction : CartDiscountUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
