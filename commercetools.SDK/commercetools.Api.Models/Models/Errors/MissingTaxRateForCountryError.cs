using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("MissingTaxRateForCountry")]
    public class MissingTaxRateForCountryError : ErrorObject
    {
        public string TaxCategoryId { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
    }
}
