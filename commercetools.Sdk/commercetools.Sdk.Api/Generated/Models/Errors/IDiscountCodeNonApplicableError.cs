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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError))]
    public partial interface IDiscountCodeNonApplicableError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string DiscountCode { get; set; }

        string Reason { get; set; }

        string DiscountCodeId { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ValidityCheckTime { get; set; }

    }
}
