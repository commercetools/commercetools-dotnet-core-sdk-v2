using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.TaxCategorys
{
    public class TaxRate 
    {
        public string Id { get; set;}
        
        public string Name { get; set;}
        
        public double Amount { get; set;}
        
        public bool IncludedInPrice { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        
        public List<SubRate> SubRates { get; set;}
    }
}
