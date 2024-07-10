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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError))]
    public partial interface IGraphQLInvalidItemShippingDetailsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string Subject { get; set; }

        string ItemId { get; set; }

    }
}
