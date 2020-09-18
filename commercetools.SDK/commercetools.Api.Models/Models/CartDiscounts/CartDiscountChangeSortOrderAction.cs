using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeSortOrder")]
    public class CartDiscountChangeSortOrderAction : CartDiscountUpdateAction
    {
        public string SortOrder { get; set;}
    }
}
