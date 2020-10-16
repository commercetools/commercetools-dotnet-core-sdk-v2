using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("changeTaxCategory")]
    public partial class ShippingMethodChangeTaxCategoryAction : ShippingMethodUpdateAction
    {
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        public ShippingMethodChangeTaxCategoryAction()
        { 
           this.Action = "changeTaxCategory";
        }
    }
}
