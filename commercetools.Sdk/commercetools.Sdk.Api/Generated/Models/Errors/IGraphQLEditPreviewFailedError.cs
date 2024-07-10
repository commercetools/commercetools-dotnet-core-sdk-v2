using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError))]
    public partial interface IGraphQLEditPreviewFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IOrderEditPreviewFailure Result { get; set; }

    }
}
