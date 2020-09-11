using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingMethodChangeTaxCategoryAction : ShippingMethodUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
