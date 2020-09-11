using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountChangeSortOrderAction : CartDiscountUpdateAction
    {
        public string SortOrder { get; set;}
    }
}
