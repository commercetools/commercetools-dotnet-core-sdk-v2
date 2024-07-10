using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError))]
    public partial interface IMissingTaxRateForCountryError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string TaxCategoryId { get; set; }

        string Country { get; set; }

        string State { get; set; }

    }
}
