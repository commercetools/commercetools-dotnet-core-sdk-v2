using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLResponse))]
    public partial interface IGraphQLResponse
    {
        Object Data { get; set; }

        List<IGraphQLError> Errors { get; set; }
    }
}
