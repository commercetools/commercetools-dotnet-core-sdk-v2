using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("changeTaxCategory")]
    public class ShippingMethodChangeTaxCategoryAction : ShippingMethodUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
