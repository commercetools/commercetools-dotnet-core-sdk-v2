using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class MissingTaxRateForCountryError : ErrorObject
    {
        public string TaxCategoryId { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
    }
}
