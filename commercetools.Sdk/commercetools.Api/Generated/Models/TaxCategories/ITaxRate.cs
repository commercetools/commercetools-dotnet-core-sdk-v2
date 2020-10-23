using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.TaxCategories
{
    public interface ITaxRate 
    {
        string Id { get; set;}
        
        string Name { get; set;}
        
        double Amount { get; set;}
        
        bool IncludedInPrice { get; set;}
        
        string Country { get; set;}
        
        string State { get; set;}
        
        List<ISubRate> SubRates { get; set;}
    }
}
