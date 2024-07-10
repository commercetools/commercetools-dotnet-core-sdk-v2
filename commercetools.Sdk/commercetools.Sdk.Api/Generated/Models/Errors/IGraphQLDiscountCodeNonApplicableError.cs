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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError))]
    public partial interface IGraphQLDiscountCodeNonApplicableError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string DiscountCode { get; set; }

        string Reason { get; set; }

        string DiscountCodeId { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ValidityCheckTime { get; set; }

    }
}
