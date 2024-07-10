using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMissingTaxRateForCountryError : IGraphQLMissingTaxRateForCountryError
    {
        public string Code { get; set; }

        public string TaxCategoryId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }
        public GraphQLMissingTaxRateForCountryError()
        {
            this.Code = "MissingTaxRateForCountry";
        }
    }
}
