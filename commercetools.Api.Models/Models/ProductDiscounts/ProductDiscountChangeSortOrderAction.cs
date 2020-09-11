using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    public class ProductDiscountChangeSortOrderAction : ProductDiscountUpdateAction
    {
        public string SortOrder { get; set;}
    }
}
