using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("MissingTaxRateForCountry")]
    public partial class MissingTaxRateForCountryError : ErrorObject
    {
        public string TaxCategoryId { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        public MissingTaxRateForCountryError()
        { 
           this.Code = "MissingTaxRateForCountry";
        }
    }
}
