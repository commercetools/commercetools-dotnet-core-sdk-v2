using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    public class ProductDiscountValueAbsolute : ProductDiscountValue
    {
        public List<TypedMoney> Money { get; set;}
    }
}
