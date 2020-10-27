using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class ExternalTaxRateDraft : IExternalTaxRateDraft
    {
        public string Name { get; set;}
        
        public double? Amount { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        
        public List<ISubRate> SubRates { get; set;}
        
        public bool? IncludedInPrice { get; set;}
    }
}
