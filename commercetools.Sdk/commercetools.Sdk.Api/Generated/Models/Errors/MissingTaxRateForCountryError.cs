using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MissingTaxRateForCountryError : IMissingTaxRateForCountryError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string TaxCategoryId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }
        public MissingTaxRateForCountryError()
        {
            this.Code = "MissingTaxRateForCountry";
        }
    }
}
