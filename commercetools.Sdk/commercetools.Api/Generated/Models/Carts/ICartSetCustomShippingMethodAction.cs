using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetCustomShippingMethodAction : ICartUpdateAction
    {
        string ShippingMethodName { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
