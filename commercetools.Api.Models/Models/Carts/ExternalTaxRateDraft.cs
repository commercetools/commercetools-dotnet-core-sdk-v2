using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class ExternalTaxRateDraft 
    {
        public string Name { get; set;}
        
        public double Amount { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        
        public List<SubRate> SubRates { get; set;}
        
        public bool IncludedInPrice { get; set;}
    }
}
