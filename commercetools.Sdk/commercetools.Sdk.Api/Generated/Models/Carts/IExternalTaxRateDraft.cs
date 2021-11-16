using commercetools.Api.Models.TaxCategories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ExternalTaxRateDraft))]
    public partial interface IExternalTaxRateDraft 
    {
        string Name { get; set;}
        
        double? Amount { get; set;}
        
        string Country { get; set;}
        
        string State { get; set;}
        
        List<ISubRate> SubRates { get; set;}
        
        bool? IncludedInPrice { get; set;}
    }
}
