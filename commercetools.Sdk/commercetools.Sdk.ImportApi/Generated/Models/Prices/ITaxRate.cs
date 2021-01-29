using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Prices.TaxRate))]
    public partial interface ITaxRate 
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
