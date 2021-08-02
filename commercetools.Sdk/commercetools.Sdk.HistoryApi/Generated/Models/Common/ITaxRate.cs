using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.TaxRate))]
    public partial interface ITaxRate 
    {
        string Id { get; set;}
        
        string Name { get; set;}
        
        int Amount { get; set;}
        
        bool IncludedInPrice { get; set;}
        
        string Country { get; set;}
        
        string State { get; set;}
        
        List<ISubRate> SubRates { get; set;}
    }
}
