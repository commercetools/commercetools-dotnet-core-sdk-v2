using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
