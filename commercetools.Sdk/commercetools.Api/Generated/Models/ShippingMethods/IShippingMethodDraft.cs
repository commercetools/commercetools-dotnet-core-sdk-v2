using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IShippingMethodDraft 
    {
        string Key { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        ILocalizedString LocalizedDescription { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        List<IZoneRateDraft> ZoneRates { get; set;}
        
        bool IsDefault { get; set;}
        
        string Predicate { get; set;}
    }
}
