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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLResponse))]
    public partial interface IGraphQLResponse
    {
        Object Data { get; set; }

        IList<IGraphQLError> Errors { get; set; }
        IEnumerable<IGraphQLError> ErrorsEnumerable { set => Errors = value.ToList(); }


    }
}
