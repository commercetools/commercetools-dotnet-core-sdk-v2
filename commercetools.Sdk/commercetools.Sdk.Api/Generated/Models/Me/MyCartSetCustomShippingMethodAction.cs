using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomShippingMethod")]
    public partial class MyCartSetCustomShippingMethodAction : MyCartUpdateAction
    {
        public string ShippingMethodName { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public MyCartSetCustomShippingMethodAction()
        { 
           this.Action = "setCustomShippingMethod";
        }
    }
}
