using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomShippingMethod")]
    public partial class CartSetCustomShippingMethodAction : CartUpdateAction
    {
        public string ShippingMethodName { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetCustomShippingMethodAction()
        { 
           this.Action = "setCustomShippingMethod";
        }
    }
}
