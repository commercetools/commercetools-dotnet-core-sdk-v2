using commercetools.Sdk.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLRequest))]
    public partial interface IGraphQLRequest
    {
        string Query { get; set; }

        string OperationName { get; set; }

        IGraphQLVariablesMap Variables { get; set; }

    }
}
