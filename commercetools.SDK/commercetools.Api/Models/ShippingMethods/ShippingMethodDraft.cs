using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodDraft 
    {
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public LocalizedString LocalizedDescription { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public List<ZoneRateDraft> ZoneRates { get; set;}
        
        public bool IsDefault { get; set;}
        
        public string Predicate { get; set;}
    }
}
