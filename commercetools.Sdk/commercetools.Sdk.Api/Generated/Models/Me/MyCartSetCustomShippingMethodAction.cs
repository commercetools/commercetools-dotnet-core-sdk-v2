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
    public  partial class MyCartSetCustomShippingMethodAction : IMyCartSetCustomShippingMethodAction
    {
        public string Action { get; set;}
        
        public string ShippingMethodName { get; set;}
        
        public IShippingRateDraft ShippingRate { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public MyCartSetCustomShippingMethodAction()
        { 
           this.Action = "setCustomShippingMethod";
        }
    }
}
