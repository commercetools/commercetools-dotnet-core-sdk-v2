using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeIsActive")]
    public class ProductDiscountChangeIsActiveAction : ProductDiscountUpdateAction
    {
        public bool IsActive { get; set;}
    }
}
