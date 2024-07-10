using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceKeyError))]
    public partial interface IDuplicatePriceKeyError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IPrice ConflictingPrice { get; set; }

    }
}
